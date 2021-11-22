namespace Win.Escuela
{
    partial class FormMaestro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label claseIdLabel;
            System.Windows.Forms.Label gradoIdLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestro));
            this.listaMaestrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaMaestrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaMaestrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaClasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseIdComboBox = new System.Windows.Forms.ComboBox();
            this.gradoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaGradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradosBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            claseIdLabel = new System.Windows.Forms.Label();
            gradoIdLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaestrosBindingNavigator)).BeginInit();
            this.listaMaestrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaestrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(37, 546);
            activoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(52, 18);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(37, 126);
            cedulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(58, 18);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(37, 282);
            celularLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(58, 18);
            celularLabel.TabIndex = 7;
            celularLabel.Text = "Celular:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(37, 334);
            correoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(59, 18);
            correoLabel.TabIndex = 9;
            correoLabel.Text = "Correo:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(37, 230);
            edadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(46, 18);
            edadLabel.TabIndex = 11;
            edadLabel.Text = "Edad:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(37, 74);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 18);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(37, 178);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(66, 18);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Nombre:";
            // 
            // claseIdLabel
            // 
            claseIdLabel.AutoSize = true;
            claseIdLabel.Location = new System.Drawing.Point(37, 440);
            claseIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            claseIdLabel.Name = "claseIdLabel";
            claseIdLabel.Size = new System.Drawing.Size(50, 18);
            claseIdLabel.TabIndex = 20;
            claseIdLabel.Text = "Clase:";
            // 
            // gradoIdLabel
            // 
            gradoIdLabel.AutoSize = true;
            gradoIdLabel.Location = new System.Drawing.Point(37, 494);
            gradoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gradoIdLabel.Name = "gradoIdLabel";
            gradoIdLabel.Size = new System.Drawing.Size(54, 18);
            gradoIdLabel.TabIndex = 22;
            gradoIdLabel.Text = "Grado:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(37, 386);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(75, 18);
            direccionLabel.TabIndex = 23;
            direccionLabel.Text = "Direccion:";
            // 
            // listaMaestrosBindingNavigator
            // 
            this.listaMaestrosBindingNavigator.AddNewItem = null;
            this.listaMaestrosBindingNavigator.BackColor = System.Drawing.Color.Turquoise;
            this.listaMaestrosBindingNavigator.BindingSource = this.listaMaestrosBindingSource;
            this.listaMaestrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaMaestrosBindingNavigator.DeleteItem = null;
            this.listaMaestrosBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMaestrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaMaestrosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaMaestrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaMaestrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaMaestrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaMaestrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaMaestrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaMaestrosBindingNavigator.Name = "listaMaestrosBindingNavigator";
            this.listaMaestrosBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.listaMaestrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaMaestrosBindingNavigator.Size = new System.Drawing.Size(1102, 28);
            this.listaMaestrosBindingNavigator.TabIndex = 0;
            this.listaMaestrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaMaestrosBindingSource
            // 
            this.listaMaestrosBindingSource.DataSource = typeof(BL.Escuela.Maestro);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(60, 25);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaMaestrosBindingNavigatorSaveItem
            // 
            this.listaMaestrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaMaestrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaMaestrosBindingNavigatorSaveItem.Image")));
            this.listaMaestrosBindingNavigatorSaveItem.Name = "listaMaestrosBindingNavigatorSaveItem";
            this.listaMaestrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 25);
            this.listaMaestrosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaMaestrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaMaestrosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(90, 29);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaMaestrosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(128, 540);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(477, 33);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Cedula", true));
            this.cedulaTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cedulaTextBox.Location = new System.Drawing.Point(128, 120);
            this.cedulaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(475, 24);
            this.cedulaTextBox.TabIndex = 6;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Celular", true));
            this.celularTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.celularTextBox.Location = new System.Drawing.Point(128, 276);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(475, 24);
            this.celularTextBox.TabIndex = 8;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Correo", true));
            this.correoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.correoTextBox.Location = new System.Drawing.Point(128, 328);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(475, 24);
            this.correoTextBox.TabIndex = 10;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Edad", true));
            this.edadTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.edadTextBox.Location = new System.Drawing.Point(128, 224);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(475, 24);
            this.edadTextBox.TabIndex = 12;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(128, 68);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(475, 24);
            this.idTextBox.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Nombre", true));
            this.nombreTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nombreTextBox.Location = new System.Drawing.Point(128, 172);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(475, 24);
            this.nombreTextBox.TabIndex = 16;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaMaestrosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(651, 120);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(334, 264);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 18;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // listaClasesBindingSource
            // 
            this.listaClasesBindingSource.DataSource = typeof(BL.Escuela.Clase);
            // 
            // claseIdComboBox
            // 
            this.claseIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMaestrosBindingSource, "ClaseId", true));
            this.claseIdComboBox.DataSource = this.listaClasesBindingSource;
            this.claseIdComboBox.DisplayMember = "Descripcion";
            this.claseIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claseIdComboBox.FormattingEnabled = true;
            this.claseIdComboBox.Location = new System.Drawing.Point(129, 432);
            this.claseIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.claseIdComboBox.Name = "claseIdComboBox";
            this.claseIdComboBox.Size = new System.Drawing.Size(474, 26);
            this.claseIdComboBox.TabIndex = 21;
            this.claseIdComboBox.ValueMember = "Id";
            // 
            // gradoIdComboBox
            // 
            this.gradoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMaestrosBindingSource, "GradoId", true));
            this.gradoIdComboBox.DataSource = this.listaGradosBindingSource;
            this.gradoIdComboBox.DisplayMember = "Descripcion";
            this.gradoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradoIdComboBox.FormattingEnabled = true;
            this.gradoIdComboBox.Location = new System.Drawing.Point(128, 486);
            this.gradoIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradoIdComboBox.Name = "gradoIdComboBox";
            this.gradoIdComboBox.Size = new System.Drawing.Size(475, 26);
            this.gradoIdComboBox.TabIndex = 23;
            this.gradoIdComboBox.ValueMember = "Id";
            // 
            // listaGradosBindingSource
            // 
            this.listaGradosBindingSource.DataMember = "ListaGrados";
            this.listaGradosBindingSource.DataSource = this.gradosBLBindingSource;
            // 
            // gradosBLBindingSource
            // 
            this.gradosBLBindingSource.DataSource = typeof(BL.Escuela.GradosBL);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaestrosBindingSource, "Direccion", true));
            this.direccionTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.direccionTextBox.Location = new System.Drawing.Point(128, 380);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(474, 24);
            this.direccionTextBox.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(873, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(651, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 24);
            this.textBox1.TabIndex = 31;
            // 
            // FormMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 586);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(gradoIdLabel);
            this.Controls.Add(this.gradoIdComboBox);
            this.Controls.Add(claseIdLabel);
            this.Controls.Add(this.claseIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaMaestrosBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMaestro";
            this.Text = "Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.listaMaestrosBindingNavigator)).EndInit();
            this.listaMaestrosBindingNavigator.ResumeLayout(false);
            this.listaMaestrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaestrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaMaestrosBindingSource;
        private System.Windows.Forms.BindingNavigator listaMaestrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaMaestrosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaClasesBindingSource;
        private System.Windows.Forms.ComboBox claseIdComboBox;
        private System.Windows.Forms.ComboBox gradoIdComboBox;
        private System.Windows.Forms.BindingSource listaGradosBindingSource;
        private System.Windows.Forms.BindingSource gradosBLBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}