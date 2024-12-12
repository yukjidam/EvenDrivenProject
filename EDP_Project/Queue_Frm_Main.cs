using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDP_Project
{
    public partial class Queue_Frm_Main : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static Patients ongoingPatient = null;
        public static Patients nextPatient = null;
        public static Queue<Patients> patientQueue = new Queue<Patients>();
        private List<Patients> accommodatedPatients = new List<Patients>();

        Queue_Frm queueForm = new Queue_Frm();
        private Timer timerOngoing = new Timer();
        private int elapsedTime = 0;

        public Queue_Frm_Main()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            LoadPatientsIntoComboBox();

            cmb_list_patients.DropDown += Cmb_list_patients_DropDown; 
            cmb_list_patients.SelectedIndexChanged += cmb_list_patients_SelectedIndexChanged; 

            timerOngoing.Interval = 1000;
            timerOngoing.Tick += TimerOngoing_Tick;
        }

        private void TimerOngoing_Tick(object sender, EventArgs e)
        {
            if (ongoingPatient == null)
            {
                StopOngoingTimer();
                return;
            }

            elapsedTime++; 

            if (queueForm != null && !queueForm.IsDisposed)
            {
                queueForm.UpdateTimerLabel(TimeSpan.FromSeconds(elapsedTime).ToString(@"hh\:mm\:ss"));
            }
        }

        private void btn_show_queue_Click(object sender, EventArgs e)
        {
            if (queueForm == null || queueForm.IsDisposed)
            {
                queueForm = new Queue_Frm();
            }
            queueForm.UpdateQueueList(patientQueue.ToList());
            queueForm.UpdateOngoingPatientLabel(ongoingPatient);
            queueForm.Show();
            queueForm.UpdateTimerLabel(GetElapsedTime());
        }

        private void LoadPatientsIntoComboBox()
        {
            string query = "SELECT ID, CONCAT(Firstname, ' ', Lastname) AS FullName FROM Patients";

            using (cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string fullName = reader.GetString(1);

                        Patients patient = new Patients(id, fullName);
                        cmb_list_patients.Items.Add(patient);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading patients: {ex.Message}");
                }
                con.Close();
            }
        }

        private void btn_addQueue_Click(object sender, EventArgs e)
        {
            if (cmb_list_patients.SelectedItem != null)
            {
                Patients selectedPatient = (Patients)cmb_list_patients.SelectedItem;

                
                if (accommodatedPatients.Any(p => p.ID == selectedPatient.ID))
                {
                    MessageBox.Show("This patient has already been accommodated and cannot be selected.");
                    return;
                }

                
                if (ongoingPatient != null && ongoingPatient.ID == selectedPatient.ID)
                {
                    MessageBox.Show("This patient is already being attended to as the ongoing patient.");
                    return;
                }

               
                if (nextPatient != null && nextPatient.ID == selectedPatient.ID)
                {
                    MessageBox.Show("This patient is already next in line.");
                    return;
                }

                
                if (patientQueue.Any(p => p.ID == selectedPatient.ID))
                {
                    MessageBox.Show("This patient is already in the queue.");
                    return;
                }

               
                if (ongoingPatient == null)
                {
                    ongoingPatient = selectedPatient;
                    StartOngoingTimer();

                    if (queueForm != null && !queueForm.IsDisposed)
                    {
                        queueForm.UpdateOngoingPatientLabel(ongoingPatient);
                    }
                }
                else if (nextPatient == null)
                {
                    nextPatient = selectedPatient;

                    if (queueForm != null && !queueForm.IsDisposed)
                    {
                        queueForm.UpdateNextPatientLabel(nextPatient);
                    }
                }
                else
                {
                    patientQueue.Enqueue(selectedPatient);

                    if (queueForm != null && !queueForm.IsDisposed)
                    {
                        queueForm.UpdateQueueList(patientQueue.ToList());
                    }
                }

                
                UpdateQueueAndAccommodatedLabels();
                MessageBox.Show("Patient added to queue.");
            }
            else
            {
                MessageBox.Show("Please select a patient from the combo box.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ongoingPatient != null)
            {
                accommodatedPatients.Add(ongoingPatient);
                listBox_acc_patients.Items.Add(ongoingPatient.ToString());
                queueForm.UpdateOngoingPatientLabel(null);
                StopOngoingTimer();
                IncrementAccommodated(Form1.CurrentUserID);
            }

            ongoingPatient = nextPatient;

            if (ongoingPatient != null)
            {
                queueForm.UpdateOngoingPatientLabel(ongoingPatient);
                nextPatient = patientQueue.Count > 0 ? patientQueue.Dequeue() : null;
                queueForm.UpdateNextPatientLabel(nextPatient);
                StartOngoingTimer();
            }
            else
            {
                queueForm.UpdateNextPatientLabel(null);
                StopOngoingTimer();
            }

            queueForm.UpdateQueueList(patientQueue.ToList());
            UpdateQueueAndAccommodatedLabels();
        }
        private void IncrementAccommodated(int ID)
        {
            try
            {
                
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                
                string incrementQuery = @"
            IF EXISTS (SELECT 1 FROM Dentist WHERE ID = @ID)
            BEGIN
                UPDATE Dentist 
                SET Accommodate = ISNULL(Accommodate, 0) + 1 
                WHERE ID = @ID
            END
            ELSE
            BEGIN
                INSERT INTO Dentist (ID, Accommodate) 
                VALUES (@ID, 1)
            END";

                using (SqlCommand incrementCmd = new SqlCommand(incrementQuery, con))
                {
                    incrementCmd.Parameters.AddWithValue("@ID", ID);
                    incrementCmd.ExecuteNonQuery();  
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error incrementing Accommodated: " + ex.Message);
            }
        }

        private void Queue_Frm_Main_Load(object sender, EventArgs e)
        {
            UpdateQueueAndAccommodatedLabels();
        }

        public void StartOngoingTimer()
        {
            if (!timerOngoing.Enabled)
            {
                elapsedTime = 0;
                timerOngoing.Start();
            }
        }

        public void StopOngoingTimer()
        {
            if (timerOngoing.Enabled)
            {
                timerOngoing.Stop();
                elapsedTime = 0;
            }
        }

        public string GetElapsedTime()
        {
            return TimeSpan.FromSeconds(elapsedTime).ToString(@"hh\:mm\:ss");
        }

        private void UpdateQueueAndAccommodatedLabels()
        {
            int totalInQueue = patientQueue.Count;
            if (ongoingPatient != null) totalInQueue++;
            if (nextPatient != null) totalInQueue++;

            lbl_total_in_queue.Text = $"{totalInQueue}";
            lbl_total_accommodated.Text = $"{accommodatedPatients.Count}";
        }

        private void RefreshComboBox()
        {
            cmb_list_patients.Items.Clear();
            LoadPatientsIntoComboBox();
        }

        private void cmb_list_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Cmb_list_patients_DropDown(object sender, EventArgs e)
        {
            RefreshComboBox();
        }
    }
}
