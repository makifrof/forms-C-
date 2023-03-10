using System;
using System.Windows.Forms;

namespace Empresa.Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.lbSeguro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.chkEmpV = new System.Windows.Forms.CheckBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEmpD = new System.Windows.Forms.CheckBox();
            this.chkEmpN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEmpleadosD = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpN = new System.Windows.Forms.Button();
            this.btnEliminarEmpD = new System.Windows.Forms.Button();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gridEmpleadosN = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVespertino = new System.Windows.Forms.Label();
            this.gridEmpleadosV = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(612, 737);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(980, 89);
            this.txtInfo.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.txtSeguro);
            this.panel1.Controls.Add(this.lbSeguro);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lbCelular);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.chkEmpV);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkEmpD);
            this.panel1.Controls.Add(this.chkEmpN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 585);
            this.panel1.TabIndex = 80;
            this.panel1.Tag = "";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(246, 385);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSeguro.Size = new System.Drawing.Size(280, 35);
            this.txtSeguro.TabIndex = 69;
            // 
            // lbSeguro
            // 
            this.lbSeguro.AutoSize = true;
            this.lbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeguro.Location = new System.Drawing.Point(16, 388);
            this.lbSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeguro.Name = "lbSeguro";
            this.lbSeguro.Size = new System.Drawing.Size(202, 33);
            this.lbSeguro.TabIndex = 68;
            this.lbSeguro.Text = "No. producto:";
            this.lbSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSeguro.Click += new System.EventHandler(this.lbSeguro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 66;
            this.label5.Text = "Modelo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(246, 338);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCelular.Size = new System.Drawing.Size(280, 35);
            this.txtCelular.TabIndex = 65;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(246, 291);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCorreo.Size = new System.Drawing.Size(280, 35);
            this.txtCorreo.TabIndex = 64;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(16, 340);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(161, 33);
            this.lbCelular.TabIndex = 63;
            this.lbCelular.Text = "Velocidad:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(16, 291);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(94, 33);
            this.lbEmail.TabIndex = 62;
            this.lbEmail.Text = "Peso:";
            // 
            // chkEmpV
            // 
            this.chkEmpV.AutoSize = true;
            this.chkEmpV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpV.Location = new System.Drawing.Point(8, 525);
            this.chkEmpV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpV.Name = "chkEmpV";
            this.chkEmpV.Size = new System.Drawing.Size(166, 41);
            this.chkEmpV.TabIndex = 61;
            this.chkEmpV.Text = "Marítimo";
            this.chkEmpV.UseVisualStyleBackColor = true;
            this.chkEmpV.CheckedChanged += new System.EventHandler(this.ChkEmpV_CheckStateChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(246, 242);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSalario.Size = new System.Drawing.Size(280, 35);
            this.txtSalario.TabIndex = 14;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 33);
            this.label10.TabIndex = 13;
            this.label10.Text = "Año:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(246, 148);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(278, 35);
            this.txtApellido2.TabIndex = 12;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(246, 194);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(278, 35);
            this.txtCedula.TabIndex = 10;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(246, 103);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(278, 35);
            this.txtApellido1.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(246, 54);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(246, 8);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(277, 35);
            this.txtID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkEmpD
            // 
            this.chkEmpD.AutoSize = true;
            this.chkEmpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpD.Location = new System.Drawing.Point(8, 431);
            this.chkEmpD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpD.Name = "chkEmpD";
            this.chkEmpD.Size = new System.Drawing.Size(172, 41);
            this.chkEmpD.TabIndex = 59;
            this.chkEmpD.Text = "Terrestre";
            this.chkEmpD.UseVisualStyleBackColor = true;
            this.chkEmpD.CheckedChanged += new System.EventHandler(this.chkEmpD_CheckedChanged);
            this.chkEmpD.CheckStateChanged += new System.EventHandler(this.ChkEmpD_CheckStateChanged);
            // 
            // chkEmpN
            // 
            this.chkEmpN.AutoSize = true;
            this.chkEmpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpN.Location = new System.Drawing.Point(8, 478);
            this.chkEmpN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpN.Name = "chkEmpN";
            this.chkEmpN.Size = new System.Drawing.Size(128, 41);
            this.chkEmpN.TabIndex = 60;
            this.chkEmpN.Text = "Aéreo";
            this.chkEmpN.UseVisualStyleBackColor = true;
            this.chkEmpN.CheckedChanged += new System.EventHandler(this.ChkEmpN_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // gridEmpleadosD
            // 
            this.gridEmpleadosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosD.Location = new System.Drawing.Point(612, 63);
            this.gridEmpleadosD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosD.Name = "gridEmpleadosD";
            this.gridEmpleadosD.RowHeadersWidth = 62;
            this.gridEmpleadosD.Size = new System.Drawing.Size(982, 181);
            this.gridEmpleadosD.TabIndex = 81;
            this.gridEmpleadosD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleadosD_CellContentClick);
            this.gridEmpleadosD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosD_RowHeaderMouseClick);
            // 
            // btnEliminarEmpN
            // 
            this.btnEliminarEmpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpN.Location = new System.Drawing.Point(321, 737);
            this.btnEliminarEmpN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpN.Name = "btnEliminarEmpN";
            this.btnEliminarEmpN.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpN.TabIndex = 86;
            this.btnEliminarEmpN.Text = "Eliminar Aéreo";
            this.btnEliminarEmpN.UseVisualStyleBackColor = true;
            this.btnEliminarEmpN.Click += new System.EventHandler(this.btnEliminarEmpN_Click_1);
            // 
            // btnEliminarEmpD
            // 
            this.btnEliminarEmpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpD.Location = new System.Drawing.Point(321, 692);
            this.btnEliminarEmpD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpD.Name = "btnEliminarEmpD";
            this.btnEliminarEmpD.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpD.TabIndex = 85;
            this.btnEliminarEmpD.Text = "Eliminar Terrestre";
            this.btnEliminarEmpD.UseVisualStyleBackColor = true;
            this.btnEliminarEmpD.Click += new System.EventHandler(this.btnEliminarEmpD_Click_1);
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmp.Location = new System.Drawing.Point(32, 689);
            this.btnAgregarEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(267, 35);
            this.btnAgregarEmp.TabIndex = 83;
            this.btnAgregarEmp.Text = "Agregar Vehiculo";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(160, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(210, 47);
            this.label20.TabIndex = 82;
            this.label20.Text = "Vehículos";
            // 
            // gridEmpleadosN
            // 
            this.gridEmpleadosN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosN.Location = new System.Drawing.Point(612, 326);
            this.gridEmpleadosN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosN.Name = "gridEmpleadosN";
            this.gridEmpleadosN.RowHeadersWidth = 62;
            this.gridEmpleadosN.Size = new System.Drawing.Size(982, 165);
            this.gridEmpleadosN.TabIndex = 79;
            this.gridEmpleadosN.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosN_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1018, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 47);
            this.label9.TabIndex = 78;
            this.label9.Text = "Aéreo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTurno
            // 
            this.txtTurno.Enabled = false;
            this.txtTurno.Location = new System.Drawing.Point(612, 448);
            this.txtTurno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(148, 26);
            this.txtTurno.TabIndex = 87;
            this.txtTurno.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(982, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 47);
            this.label8.TabIndex = 77;
            this.label8.Text = "Terrestre";
            // 
            // lbVespertino
            // 
            this.lbVespertino.AutoSize = true;
            this.lbVespertino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbVespertino.Location = new System.Drawing.Point(997, 501);
            this.lbVespertino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVespertino.Name = "lbVespertino";
            this.lbVespertino.Size = new System.Drawing.Size(187, 47);
            this.lbVespertino.TabIndex = 95;
            this.lbVespertino.Text = "Marítimo";
            // 
            // gridEmpleadosV
            // 
            this.gridEmpleadosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosV.Location = new System.Drawing.Point(612, 562);
            this.gridEmpleadosV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosV.Name = "gridEmpleadosV";
            this.gridEmpleadosV.RowHeadersWidth = 62;
            this.gridEmpleadosV.Size = new System.Drawing.Size(994, 162);
            this.gridEmpleadosV.TabIndex = 96;
            this.gridEmpleadosV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosV_RowHeaderMouseClick);
            // 
            // btnEliminarEmpV
            // 
            this.btnEliminarEmpV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpV.Location = new System.Drawing.Point(33, 737);
            this.btnEliminarEmpV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpV.Name = "btnEliminarEmpV";
            this.btnEliminarEmpV.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpV.TabIndex = 97;
            this.btnEliminarEmpV.Text = "Eliminar Marítimo";
            this.btnEliminarEmpV.UseVisualStyleBackColor = true;
            this.btnEliminarEmpV.Click += new System.EventHandler(this.btnEliminarEmpV_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 836);
            this.Controls.Add(this.btnEliminarEmpV);
            this.Controls.Add(this.gridEmpleadosV);
            this.Controls.Add(this.lbVespertino);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridEmpleadosD);
            this.Controls.Add(this.btnEliminarEmpN);
            this.Controls.Add(this.btnEliminarEmpD);
            this.Controls.Add(this.btnAgregarEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.gridEmpleadosN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEmpD;
        private System.Windows.Forms.CheckBox chkEmpN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridEmpleadosD;
        private System.Windows.Forms.Button btnEliminarEmpN;
        private System.Windows.Forms.Button btnEliminarEmpD;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView gridEmpleadosN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.CheckBox chkEmpV;
        private Label lbVespertino;
        private DataGridView gridEmpleadosV;
        private Label label5;
        private TextBox txtSeguro;
        private Label lbSeguro;
        private Button btnEliminarEmpV;
    }
}

