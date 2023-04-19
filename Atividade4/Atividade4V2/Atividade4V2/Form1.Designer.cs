namespace Atividade4V2
{
    partial class rbEngeneering
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameOfForm1 = new System.Windows.Forms.Label();
            this.lbCodeOfCourse = new System.Windows.Forms.Label();
            this.lbNomeOfStudents = new System.Windows.Forms.Label();
            this.PhoneOfStudents = new System.Windows.Forms.Label();
            this.lbEmailOfStudents = new System.Windows.Forms.Label();
            this.txbNameOfStudents = new System.Windows.Forms.TextBox();
            this.mtxbPhoneOfStudents = new System.Windows.Forms.MaskedTextBox();
            this.mtxbCodeOfStudents = new System.Windows.Forms.MaskedTextBox();
            this.mtxbEmailOfStudents = new System.Windows.Forms.MaskedTextBox();
            this.lbCouserOfStudents = new System.Windows.Forms.Label();
            this.btAddStudents = new System.Windows.Forms.Button();
            this.rbAnalistyOfSystem = new System.Windows.Forms.RadioButton();
            this.rbSystemInformation = new System.Windows.Forms.RadioButton();
            this.rbEngeenering = new System.Windows.Forms.RadioButton();
            this.rbRedes = new System.Windows.Forms.RadioButton();
            this.gdvDataOsStudents = new System.Windows.Forms.DataGridView();
            this.btSearchStudents = new System.Windows.Forms.Button();
            this.btClearTextOfForms = new System.Windows.Forms.Button();
            this.btAlterDataOfStudents = new System.Windows.Forms.Button();
            this.btDeleteDataOfStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDataOsStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameOfForm1
            // 
            this.lbNameOfForm1.AutoSize = true;
            this.lbNameOfForm1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameOfForm1.Location = new System.Drawing.Point(313, 9);
            this.lbNameOfForm1.Name = "lbNameOfForm1";
            this.lbNameOfForm1.Size = new System.Drawing.Size(145, 54);
            this.lbNameOfForm1.TabIndex = 0;
            this.lbNameOfForm1.Text = "Alunos";
            // 
            // lbCodeOfCourse
            // 
            this.lbCodeOfCourse.AutoSize = true;
            this.lbCodeOfCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodeOfCourse.Location = new System.Drawing.Point(21, 85);
            this.lbCodeOfCourse.Name = "lbCodeOfCourse";
            this.lbCodeOfCourse.Size = new System.Drawing.Size(86, 28);
            this.lbCodeOfCourse.TabIndex = 1;
            this.lbCodeOfCourse.Text = "Codigo: ";
            // 
            // lbNomeOfStudents
            // 
            this.lbNomeOfStudents.AutoSize = true;
            this.lbNomeOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomeOfStudents.Location = new System.Drawing.Point(21, 124);
            this.lbNomeOfStudents.Name = "lbNomeOfStudents";
            this.lbNomeOfStudents.Size = new System.Drawing.Size(75, 28);
            this.lbNomeOfStudents.TabIndex = 2;
            this.lbNomeOfStudents.Text = "Nome: ";
            // 
            // PhoneOfStudents
            // 
            this.PhoneOfStudents.AutoSize = true;
            this.PhoneOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneOfStudents.Location = new System.Drawing.Point(21, 164);
            this.PhoneOfStudents.Name = "PhoneOfStudents";
            this.PhoneOfStudents.Size = new System.Drawing.Size(93, 28);
            this.PhoneOfStudents.TabIndex = 3;
            this.PhoneOfStudents.Text = "Telefone: ";
            // 
            // lbEmailOfStudents
            // 
            this.lbEmailOfStudents.AutoSize = true;
            this.lbEmailOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmailOfStudents.Location = new System.Drawing.Point(21, 203);
            this.lbEmailOfStudents.Name = "lbEmailOfStudents";
            this.lbEmailOfStudents.Size = new System.Drawing.Size(76, 28);
            this.lbEmailOfStudents.TabIndex = 4;
            this.lbEmailOfStudents.Text = "E-mail: ";
            // 
            // txbNameOfStudents
            // 
            this.txbNameOfStudents.Location = new System.Drawing.Point(93, 125);
            this.txbNameOfStudents.Name = "txbNameOfStudents";
            this.txbNameOfStudents.Size = new System.Drawing.Size(220, 27);
            this.txbNameOfStudents.TabIndex = 5;
            // 
            // mtxbPhoneOfStudents
            // 
            this.mtxbPhoneOfStudents.Location = new System.Drawing.Point(120, 164);
            this.mtxbPhoneOfStudents.Mask = "(99) 90000-0000";
            this.mtxbPhoneOfStudents.Name = "mtxbPhoneOfStudents";
            this.mtxbPhoneOfStudents.Size = new System.Drawing.Size(193, 27);
            this.mtxbPhoneOfStudents.TabIndex = 7;
            // 
            // mtxbCodeOfStudents
            // 
            this.mtxbCodeOfStudents.Location = new System.Drawing.Point(103, 86);
            this.mtxbCodeOfStudents.Mask = "000000";
            this.mtxbCodeOfStudents.Name = "mtxbCodeOfStudents";
            this.mtxbCodeOfStudents.Size = new System.Drawing.Size(210, 27);
            this.mtxbCodeOfStudents.TabIndex = 8;
            // 
            // mtxbEmailOfStudents
            // 
            this.mtxbEmailOfStudents.Location = new System.Drawing.Point(93, 207);
            this.mtxbEmailOfStudents.Name = "mtxbEmailOfStudents";
            this.mtxbEmailOfStudents.Size = new System.Drawing.Size(220, 27);
            this.mtxbEmailOfStudents.TabIndex = 9;
            // 
            // lbCouserOfStudents
            // 
            this.lbCouserOfStudents.AutoSize = true;
            this.lbCouserOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCouserOfStudents.Location = new System.Drawing.Point(21, 246);
            this.lbCouserOfStudents.Name = "lbCouserOfStudents";
            this.lbCouserOfStudents.Size = new System.Drawing.Size(74, 28);
            this.lbCouserOfStudents.TabIndex = 10;
            this.lbCouserOfStudents.Text = "Cursos:";
            // 
            // btAddStudents
            // 
            this.btAddStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddStudents.Location = new System.Drawing.Point(349, 137);
            this.btAddStudents.Name = "btAddStudents";
            this.btAddStudents.Size = new System.Drawing.Size(109, 46);
            this.btAddStudents.TabIndex = 11;
            this.btAddStudents.Text = "Adicionar";
            this.btAddStudents.UseVisualStyleBackColor = true;
            this.btAddStudents.Click += new System.EventHandler(this.btAddStudents_Click);
            // 
            // rbAnalistyOfSystem
            // 
            this.rbAnalistyOfSystem.AutoSize = true;
            this.rbAnalistyOfSystem.Location = new System.Drawing.Point(103, 251);
            this.rbAnalistyOfSystem.Name = "rbAnalistyOfSystem";
            this.rbAnalistyOfSystem.Size = new System.Drawing.Size(155, 24);
            this.rbAnalistyOfSystem.TabIndex = 12;
            this.rbAnalistyOfSystem.TabStop = true;
            this.rbAnalistyOfSystem.Text = "Analise de Sistema";
            this.rbAnalistyOfSystem.UseVisualStyleBackColor = true;
            // 
            // rbSystemInformation
            // 
            this.rbSystemInformation.AutoSize = true;
            this.rbSystemInformation.Location = new System.Drawing.Point(275, 250);
            this.rbSystemInformation.Name = "rbSystemInformation";
            this.rbSystemInformation.Size = new System.Drawing.Size(183, 24);
            this.rbSystemInformation.TabIndex = 13;
            this.rbSystemInformation.TabStop = true;
            this.rbSystemInformation.Text = "Sistema da informação";
            this.rbSystemInformation.UseVisualStyleBackColor = true;
            // 
            // rbEngeenering
            // 
            this.rbEngeenering.AutoSize = true;
            this.rbEngeenering.Location = new System.Drawing.Point(103, 281);
            this.rbEngeenering.Name = "rbEngeenering";
            this.rbEngeenering.Size = new System.Drawing.Size(104, 24);
            this.rbEngeenering.TabIndex = 14;
            this.rbEngeenering.TabStop = true;
            this.rbEngeenering.Text = "Engenharia";
            this.rbEngeenering.UseVisualStyleBackColor = true;
            // 
            // rbRedes
            // 
            this.rbRedes.AutoSize = true;
            this.rbRedes.Location = new System.Drawing.Point(275, 281);
            this.rbRedes.Name = "rbRedes";
            this.rbRedes.Size = new System.Drawing.Size(70, 24);
            this.rbRedes.TabIndex = 15;
            this.rbRedes.TabStop = true;
            this.rbRedes.Text = "Redes";
            this.rbRedes.UseVisualStyleBackColor = true;
            // 
            // gdvDataOsStudents
            // 
            this.gdvDataOsStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDataOsStudents.Location = new System.Drawing.Point(12, 329);
            this.gdvDataOsStudents.Name = "gdvDataOsStudents";
            this.gdvDataOsStudents.RowHeadersWidth = 51;
            this.gdvDataOsStudents.RowTemplate.Height = 29;
            this.gdvDataOsStudents.Size = new System.Drawing.Size(776, 229);
            this.gdvDataOsStudents.TabIndex = 16;
            this.gdvDataOsStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvDataOsStudents_CellClick);
            // 
            // btSearchStudents
            // 
            this.btSearchStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSearchStudents.Location = new System.Drawing.Point(349, 85);
            this.btSearchStudents.Name = "btSearchStudents";
            this.btSearchStudents.Size = new System.Drawing.Size(109, 46);
            this.btSearchStudents.TabIndex = 17;
            this.btSearchStudents.Text = "Procurar";
            this.btSearchStudents.UseVisualStyleBackColor = true;
            this.btSearchStudents.Click += new System.EventHandler(this.btSearchStudents_Click);
            // 
            // btClearTextOfForms
            // 
            this.btClearTextOfForms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClearTextOfForms.Location = new System.Drawing.Point(349, 189);
            this.btClearTextOfForms.Name = "btClearTextOfForms";
            this.btClearTextOfForms.Size = new System.Drawing.Size(109, 46);
            this.btClearTextOfForms.TabIndex = 18;
            this.btClearTextOfForms.Text = "Limpar";
            this.btClearTextOfForms.UseVisualStyleBackColor = true;
            this.btClearTextOfForms.Click += new System.EventHandler(this.btClearTextOfForms_Click);
            // 
            // btAlterDataOfStudents
            // 
            this.btAlterDataOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAlterDataOfStudents.Location = new System.Drawing.Point(476, 85);
            this.btAlterDataOfStudents.Name = "btAlterDataOfStudents";
            this.btAlterDataOfStudents.Size = new System.Drawing.Size(109, 46);
            this.btAlterDataOfStudents.TabIndex = 19;
            this.btAlterDataOfStudents.Text = "Alterar";
            this.btAlterDataOfStudents.UseVisualStyleBackColor = true;
            this.btAlterDataOfStudents.Click += new System.EventHandler(this.btAlterDataOfStudents_Click);
            // 
            // btDeleteDataOfStudents
            // 
            this.btDeleteDataOfStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteDataOfStudents.Location = new System.Drawing.Point(476, 137);
            this.btDeleteDataOfStudents.Name = "btDeleteDataOfStudents";
            this.btDeleteDataOfStudents.Size = new System.Drawing.Size(109, 46);
            this.btDeleteDataOfStudents.TabIndex = 20;
            this.btDeleteDataOfStudents.Text = "Deletar";
            this.btDeleteDataOfStudents.UseVisualStyleBackColor = true;
            this.btDeleteDataOfStudents.Click += new System.EventHandler(this.btDeleteDataOfStudents_Click);
            // 
            // rbEngeneering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.btDeleteDataOfStudents);
            this.Controls.Add(this.btAlterDataOfStudents);
            this.Controls.Add(this.btClearTextOfForms);
            this.Controls.Add(this.btSearchStudents);
            this.Controls.Add(this.gdvDataOsStudents);
            this.Controls.Add(this.rbRedes);
            this.Controls.Add(this.rbEngeenering);
            this.Controls.Add(this.rbSystemInformation);
            this.Controls.Add(this.rbAnalistyOfSystem);
            this.Controls.Add(this.btAddStudents);
            this.Controls.Add(this.lbCouserOfStudents);
            this.Controls.Add(this.mtxbEmailOfStudents);
            this.Controls.Add(this.mtxbCodeOfStudents);
            this.Controls.Add(this.mtxbPhoneOfStudents);
            this.Controls.Add(this.txbNameOfStudents);
            this.Controls.Add(this.lbEmailOfStudents);
            this.Controls.Add(this.PhoneOfStudents);
            this.Controls.Add(this.lbNomeOfStudents);
            this.Controls.Add(this.lbCodeOfCourse);
            this.Controls.Add(this.lbNameOfForm1);
            this.Name = "rbEngeneering";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDataOsStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNameOfForm1;
        private Label lbCodeOfCourse;
        private Label lbNomeOfStudents;
        private Label PhoneOfStudents;
        private Label lbEmailOfStudents;
        private TextBox txbNameOfStudents;
        private MaskedTextBox mtxbPhoneOfStudents;
        private MaskedTextBox mtxbCodeOfStudents;
        private MaskedTextBox mtxbEmailOfStudents;
        private Label lbCouserOfStudents;
        private Button btAddStudents;
        private RadioButton rbAnalistyOfSystem;
        private RadioButton rbSystemInformation;
        private RadioButton rbEngeenering;
        private RadioButton rbRedes;
        private DataGridView gdvDataOsStudents;
        private Button btSearchStudents;
        private Button btClearTextOfForms;
        private Button btAlterDataOfStudents;
        private Button btDeleteDataOfStudents;
    }
}