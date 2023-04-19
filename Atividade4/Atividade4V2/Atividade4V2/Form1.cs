using Atividade4V2.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.IO;
using System;
using System.Windows.Forms;

namespace Atividade4V2
{
    public partial class rbEngeneering : Form
    {

        public List<Student> listOfStudents = new List<Student>();
        public string optionCourse = string.Empty;

        public rbEngeneering()
        {
            InitializeComponent();
        }

        public void choiceOfCourse()
        {
            if (rbAnalistyOfSystem.Checked)
            {
                optionCourse = rbAnalistyOfSystem.Text;
            }
            else if (rbSystemInformation.Checked)
            {
                optionCourse = rbSystemInformation.Text;
            }
            else if (rbEngeenering.Checked)
            {
                optionCourse = rbEngeenering.Text;
            }
            else if (rbRedes.Checked)
            {
                optionCourse = rbRedes.Text;
            }
        }
        public void choiceOfCourseChecked()
        {
            if (optionCourse == rbRedes.Text)
            {
                rbRedes.Checked = true;

            }
            if (optionCourse == rbEngeenering.Text)
            {
                rbEngeenering.Checked = true;

            }
            if (optionCourse == rbSystemInformation.Text)
            {
                rbSystemInformation.Checked = true;

            }
            if (optionCourse == rbAnalistyOfSystem.Text)
            {
                rbAnalistyOfSystem.Checked = true;
            }
        }

        private bool ValidateInput()
        {
            if (!int.TryParse(mtxbCodeOfStudents.Text, out _))
            {
                MessageBox.Show("Código do aluno inválido. Por favor, insira um número válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txbNameOfStudents.Text) || string.IsNullOrEmpty(mtxbPhoneOfStudents.Text) || string.IsNullOrEmpty(mtxbEmailOfStudents.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            return true;
        }

        private bool IsStudentCodeDuplicate(int codeOfStudent)
        {
            return listOfStudents.Any(s => s.codeOfStudent == codeOfStudent);
        }

        private void ClearSelections()
        {
            txbNameOfStudents.Text = String.Empty;
            mtxbPhoneOfStudents.Text = String.Empty;
            mtxbEmailOfStudents.Text = String.Empty;
            mtxbCodeOfStudents.Text = "0";
            rbRedes.Checked = false;
            rbAnalistyOfSystem.Checked = false;
            rbSystemInformation.Checked = false;
            rbEngeenering.Checked = false;

        }



        


        private void AddStudent(int codeOfStudent, string nameOfStudent, string phoneOfStudent, string emailOfStudent, string courseOfStudents)
        {
            Student newStudent = new()
            {
                codeOfStudent = codeOfStudent,
                nameOfStudent = nameOfStudent,
                phoneOfStudent = phoneOfStudent,
                emailOfStudent = emailOfStudent,
                courseOfStudents = courseOfStudents
            };

            listOfStudents.Add(newStudent);
        }



        private void UpdateStudentData(Student student)
        {
            student.nameOfStudent = txbNameOfStudents.Text;
            student.phoneOfStudent = mtxbPhoneOfStudents.Text;
            student.emailOfStudent = mtxbEmailOfStudents.Text;

            switch (optionCourse)
            {
                case "Redes":
                    student.courseOfStudents = "Redes de Computadores";
                    break;
                case "Análise de Sistemas":
                    student.courseOfStudents = "Análise de Sistemas";
                    break;
                case "Informática":
                    student.courseOfStudents = "Informática";
                    break;
                case "Engenharia de Software":
                    student.courseOfStudents = "Engenharia de Software";
                    break;
            }
        }






        private void btAddStudents_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            choiceOfCourse();
            if (IsStudentCodeDuplicate(int.Parse(mtxbCodeOfStudents.Text)))
            {
                MessageBox.Show("Já existe um estudante com esse código.");
                return;
            }
            AddStudent(int.Parse(mtxbCodeOfStudents.Text), txbNameOfStudents.Text, mtxbPhoneOfStudents.Text, mtxbEmailOfStudents.Text, optionCourse);
            gdvDataOsStudents.DataSource = null;
            gdvDataOsStudents.DataSource = listOfStudents;
        }
        private void btSearchStudents_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mtxbCodeOfStudents.Text, out int codeOfStudent))
            {
                MessageBox.Show("Código de estudante inválido!");
                return;
            }

            Student student = listOfStudents.Find(x => x.codeOfStudent == codeOfStudent);

            if (student != null)
            {
                txbNameOfStudents.Text = student.nameOfStudent;
                mtxbPhoneOfStudents.Text = student.phoneOfStudent;
                mtxbEmailOfStudents.Text = student.emailOfStudent;
                optionCourse = student.courseOfStudents;
                choiceOfCourseChecked();
            }
            else
            {
                MessageBox.Show("Estudante não encontrado!");
            }
        }

        private void gdvDataOsStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // verifica se a linha selecionada é válida
            {
                DataGridViewRow row = this.gdvDataOsStudents.Rows[e.RowIndex];
                mtxbCodeOfStudents.Text = row.Cells["codeOfStudent"].Value.ToString();
                txbNameOfStudents.Text = row.Cells["nameOfStudent"].Value.ToString();
                mtxbPhoneOfStudents.Text = row.Cells["phoneOfStudent"].Value.ToString();
                mtxbEmailOfStudents.Text = row.Cells["emailOfStudent"].Value.ToString();
                optionCourse = row.Cells["courseOfStudents"].Value.ToString();
                choiceOfCourseChecked();
            }
        }

        private void btClearTextOfForms_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }

        private void btAlterDataOfStudents_Click(object sender, EventArgs e)
        {

            int codeOfStudent = int.Parse(mtxbCodeOfStudents.Text);
            Student student = listOfStudents.Find(x => x.codeOfStudent == codeOfStudent);

            if (student == null)
            {
                MessageBox.Show("Estudante não encontrado!");
                return;
            }

            UpdateStudentData(student);

            MessageBox.Show("Dados do estudante atualizados com sucesso!");

            gdvDataOsStudents.Refresh();

        }

       

        private void btDeleteDataOfStudents_Click(object sender, EventArgs e)
        {
            if (gdvDataOsStudents.SelectedRows?.Count > 0)
            {
              
                int selectedIndex = gdvDataOsStudents.SelectedRows[0].Index;
                Student studentToRemove = this.listOfStudents[selectedIndex];
              
                this.listOfStudents.Remove(studentToRemove);

               
                gdvDataOsStudents.DataSource = null;
                gdvDataOsStudents.DataSource = this.listOfStudents;

   
                gdvDataOsStudents.ClearSelection();

                MessageBox.Show("Aluno removido com sucesso.");
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.");
            }
        }
    }
    }

