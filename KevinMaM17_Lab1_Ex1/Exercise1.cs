using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinMaM17_Lab1_Ex1
{
    public partial class Exercise1 : Form
    {
        //create the textboxes in global scope so they can be referenced in the event handler below
        TextBox tbStudentName;
        TextBox tbProgram;
        TextBox tbEmail;
        TextBox tbSemester;

        public Exercise1()
        {
            InitializeComponent();
        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {
            //create a form dynamically
            Form exercise1Form = new Form();
            //set the properties of the form
            exercise1Form.Text = "Dynamic Form";
            exercise1Form.ClientSize = new Size(740, 450);
            exercise1Form.StartPosition = FormStartPosition.CenterScreen;
            exercise1Form.Show();

            //populate the new form with controls
            //------------------------------------------------------------
            //LABELS
            //------------------------------------------------------------
            //create the label objects
            Label lblStudentName = new Label();
            Label lblProgram = new Label();
            Label lblEmail = new Label();
            Label lblSemester = new Label();

            //set the properties of the labels
            lblStudentName.Text = "Student Name:";
            lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStudentName.Location = new System.Drawing.Point(100, 100);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new System.Drawing.Size(200, 50);

            lblProgram.Text = "Program:";
            lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProgram.Location = new System.Drawing.Point(100, 160);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new System.Drawing.Size(200, 50);

            lblEmail.Text = "Email:";
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmail.Location = new System.Drawing.Point(100, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(200, 50);

            lblSemester.Text = "Semester:";
            lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSemester.Location = new System.Drawing.Point(100, 280);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new System.Drawing.Size(200, 50);

            //------------------------------------------------------------
            //TEXTBOXES
            //------------------------------------------------------------
            //instantiate the textbox objects
            tbStudentName = new TextBox();
            tbProgram = new TextBox();
            tbEmail = new TextBox();
            tbSemester = new TextBox();

            //set the properties of the textboxes
            tbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbStudentName.Location = new System.Drawing.Point(300, 100);
            tbStudentName.Name = "tbStudentNamee";
            tbStudentName.Size = new System.Drawing.Size(300, 50);

            tbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbProgram.Location = new System.Drawing.Point(300, 160);
            tbProgram.Name = "tbPrograme";
            tbProgram.Size = new System.Drawing.Size(300, 50);

            tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbEmail.Location = new System.Drawing.Point(300, 220);
            tbEmail.Name = "tbEmaile";
            tbEmail.Size = new System.Drawing.Size(300, 50);

            tbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbSemester.Location = new System.Drawing.Point(300, 280);
            tbSemester.Name = "tbSemestere";
            tbSemester.Size = new System.Drawing.Size(300, 50);

            //add a button to submit the student information
            Button btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmit.Location = new System.Drawing.Point(300, 340);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(200, 50);


            //add the controls to the form
            exercise1Form.Controls.Add(lblStudentName);
            exercise1Form.Controls.Add(lblProgram);
            exercise1Form.Controls.Add(lblEmail);
            exercise1Form.Controls.Add(lblSemester);

            exercise1Form.Controls.Add(tbStudentName);
            exercise1Form.Controls.Add(tbProgram);
            exercise1Form.Controls.Add(tbEmail);
            exercise1Form.Controls.Add(tbSemester);

            exercise1Form.Controls.Add(btnSubmit);

            //use the EventHandler delegate to register the event handler
            btnSubmit.Click += new EventHandler(btnSubmit_Click);

            //when the exercise1Form closes, the startup form closes as well - more user friendly, less
            //clicking for the user to do
            exercise1Form.FormClosing += (se, evt) => Close();
        }

        //create an event handler for the submit button
        private void btnSubmit_Click(Object sender, EventArgs e)
        {
            //handle the click event
            tbStudentName.Text = "Kevin Ma";
            tbProgram.Text = "SET (Co-op)";
            tbEmail.Text = "kbma.kevin@gmail.com";
            tbSemester.Text = "SEM4";
        }
    }
}
