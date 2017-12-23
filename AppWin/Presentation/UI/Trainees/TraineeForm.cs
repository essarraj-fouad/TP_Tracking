﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GwinForm;
using TP_Tracking.Entities;

namespace TP_Tracking.Presentation.UI.Trainees
{
    public partial class TraineeForm : GwinFormControl
    {
        public TraineeForm()
        {
            InitializeComponent();
        }

        public override void GetEntityFromControls()
        {
            Trainee trainee = this.Entity as Trainee;
            if (trainee == null) trainee = new Trainee();
            trainee.FirstName = firstNameTextBox.Text;
            trainee.LastName = lastNameTextBox.Text;
            trainee.DateOfBirth = dateOfBirthDateTimePicker.Value;
        }
        public override void SetEntityToControls()
        {
            Trainee trainee = this.Entity as Trainee;
            if (trainee != null)
            {
                firstNameTextBox.Text = trainee.FirstName;
                lastNameTextBox.Text = trainee.LastName;
                dateOfBirthDateTimePicker.Value = trainee.DateOfBirth;
            }

        }
    }
}
