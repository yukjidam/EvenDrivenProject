using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Queue_Frm : Form
    {
        //Collections and Generics DONE!
        public Patients OngoingPatient { get; set; }
        public Patients NextPatient { get; set; }
        public Queue<Patients> PatientQueue { get; set; }

        public Queue_Frm()
        {
            InitializeComponent();
            PatientQueue = new Queue<Patients>();
            UpdateQueueDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateQueueDisplay()
        {
            if (Queue_Frm_Main.ongoingPatient != null)
            {
                lbl_ongoing.Text = $"{Queue_Frm_Main.ongoingPatient.FullName}";
            }
            else
            {
                lbl_ongoing.Text = "";
            }

            if (Queue_Frm_Main.patientQueue.Count > 0)
            {
                lbl_next.Text = $"{Queue_Frm_Main.patientQueue.Peek().FullName}";
            }
            else
            {
                lbl_next.Text = "";
            }

            listBox_waiting_patients.Items.Clear();
            foreach (var patient in Queue_Frm_Main.patientQueue.Skip(1))
            {
                listBox_waiting_patients.Items.Add(patient.FullName);
            }
        }

        public void UpdateOngoingPatient(Patients ongoingPatient)
        {
            lbl_ongoing.Text = ongoingPatient != null ? ongoingPatient.ToString() : "No ongoing patient";
        }

        public void UpdateQueueList(Queue<Patients> patientQueue)
        {
            listBox_waiting_patients.Items.Clear();
            foreach (var patient in patientQueue)
            {
                listBox_waiting_patients.Items.Add(patient.ToString());
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateOngoingPatientLabel(Patients ongoing)
        {
            lbl_ongoing.Text = ongoing != null ? ongoing.ToString() : "";
        }

        public void UpdateNextPatientLabel(Patients next)
        {
            lbl_next.Text = next != null ? next.ToString() : "";
        }

        public void UpdateQueueList(List<Patients> patientQueue)
        {
            listBox_waiting_patients.Items.Clear();
            foreach (var patient in patientQueue)
            {
                listBox_waiting_patients.Items.Add(patient.ToString());
            }
        }

        public void UpdateOngoingPatientLabel()
        {
            lbl_ongoing.Text = OngoingPatient != null ? OngoingPatient.ToString() : "";
        }

        public void UpdateNextPatientLabel()
        {
            lbl_next.Text = NextPatient != null ? NextPatient.ToString() : "";
        }

        private int elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lbl_timer.Text = TimeSpan.FromSeconds(elapsedTime).ToString(@"hh\:mm\:ss");
        }

        public void StartTimer()
        {
            elapsedTime = 0;
            lbl_timer.Text = "00:00:00"; 
            timer1.Start();
        }

        public void StopTimer()
        {
            timer1.Stop();
            lbl_timer.Text = "00:00:00"; 
        }

        public void UpdateTimerLabel(string time)
        {
            lbl_timer.Text = time;
        }
    }
}
