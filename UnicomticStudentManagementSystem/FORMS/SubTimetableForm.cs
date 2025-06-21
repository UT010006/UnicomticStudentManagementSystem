using StudentManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.FORMS
{
    public partial class SubTimetableForm : Form
    {
        public SubTimetableForm()
        {
            InitializeComponent();
        }

        private void SubTimetableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var list = SubTimetableController.GetAll();
            dataGridViewSubTimetable.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var timetable = new SubTimetable
            {
                StuSubjectId = txtSubjectId.Text,
                SubTimeslot = txtTimeslot.Text,
                RoomId = Convert.ToInt32(txtRoomId.Text)
            };
            SubTimetableController.Insert(timetable);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubTimetable.SelectedRows.Count > 0)
            {
                int timetableId = Convert.ToInt32(dataGridViewSubTimetable.SelectedRows[0].Cells["TimetableId"].Value);
                SubTimetableController.Delete(timetableId);
                LoadData();
            }
        }
    }
}

        
    

