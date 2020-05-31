namespace PrototipoHotel
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuUp = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btExpandir = new System.Windows.Forms.PictureBox();
            this.btMinimizarMenu = new System.Windows.Forms.PictureBox();
            this.btCerrarMenu = new System.Windows.Forms.PictureBox();
            this.btReserva = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCheckout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCheckin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMenuLeft.SuspendLayout();
            this.panelMenuUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.Navy;
            this.panelMenuLeft.Controls.Add(this.btReserva);
            this.panelMenuLeft.Controls.Add(this.pictureBox1);
            this.panelMenuLeft.Controls.Add(this.btHabitaciones);
            this.panelMenuLeft.Controls.Add(this.btRegistrar);
            this.panelMenuLeft.Controls.Add(this.btCheckout);
            this.panelMenuLeft.Controls.Add(this.bunifuFlatButton1);
            this.panelMenuLeft.Controls.Add(this.btReportes);
            this.panelMenuLeft.Controls.Add(this.btCheckin);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(60, 521);
            this.panelMenuLeft.TabIndex = 6;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(60, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(828, 484);
            this.panelContenedor.TabIndex = 8;
            // 
            // panelMenuUp
            // 
            this.panelMenuUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenuUp.BackgroundImage")));
            this.panelMenuUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuUp.Controls.Add(this.btExpandir);
            this.panelMenuUp.Controls.Add(this.btMinimizarMenu);
            this.panelMenuUp.Controls.Add(this.btCerrarMenu);
            this.panelMenuUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuUp.GradientBottomLeft = System.Drawing.Color.White;
            this.panelMenuUp.GradientBottomRight = System.Drawing.Color.White;
            this.panelMenuUp.GradientTopLeft = System.Drawing.Color.White;
            this.panelMenuUp.GradientTopRight = System.Drawing.Color.White;
            this.panelMenuUp.Location = new System.Drawing.Point(60, 0);
            this.panelMenuUp.Name = "panelMenuUp";
            this.panelMenuUp.Quality = 10;
            this.panelMenuUp.Size = new System.Drawing.Size(828, 37);
            this.panelMenuUp.TabIndex = 7;
            // 
            // btExpandir
            // 
            this.btExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExpandir.Image = global::PrototipoHotel.Properties.Resources.Mobile_Menu_Icon;
            this.btExpandir.Location = new System.Drawing.Point(6, 3);
            this.btExpandir.Name = "btExpandir";
            this.btExpandir.Size = new System.Drawing.Size(25, 29);
            this.btExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExpandir.TabIndex = 40;
            this.btExpandir.TabStop = false;
            this.btExpandir.Click += new System.EventHandler(this.btExpandir_Click_1);
            // 
            // btMinimizarMenu
            // 
            this.btMinimizarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizarMenu.Image = global::PrototipoHotel.Properties.Resources.Btn_Minimizar;
            this.btMinimizarMenu.Location = new System.Drawing.Point(757, 3);
            this.btMinimizarMenu.Name = "btMinimizarMenu";
            this.btMinimizarMenu.Size = new System.Drawing.Size(25, 25);
            this.btMinimizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMinimizarMenu.TabIndex = 39;
            this.btMinimizarMenu.TabStop = false;
            this.btMinimizarMenu.Click += new System.EventHandler(this.btMinimizarMenu_Click_1);
            // 
            // btCerrarMenu
            // 
            this.btCerrarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrarMenu.Image = global::PrototipoHotel.Properties.Resources.Btn_cerrar;
            this.btCerrarMenu.Location = new System.Drawing.Point(791, 3);
            this.btCerrarMenu.Name = "btCerrarMenu";
            this.btCerrarMenu.Size = new System.Drawing.Size(25, 25);
            this.btCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCerrarMenu.TabIndex = 38;
            this.btCerrarMenu.TabStop = false;
            this.btCerrarMenu.Click += new System.EventHandler(this.btCerrarMenu_Click_1);
            // 
            // btReserva
            // 
            this.btReserva.Activecolor = System.Drawing.Color.Transparent;
            this.btReserva.BackColor = System.Drawing.Color.Navy;
            this.btReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReserva.BorderRadius = 0;
            this.btReserva.ButtonText = "     Reservas";
            this.btReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReserva.DisabledColor = System.Drawing.Color.Gray;
            this.btReserva.Iconcolor = System.Drawing.Color.Transparent;
            this.btReserva.Iconimage = global::PrototipoHotel.Properties.Resources.mes;
            this.btReserva.Iconimage_right = null;
            this.btReserva.Iconimage_right_Selected = null;
            this.btReserva.Iconimage_Selected = null;
            this.btReserva.IconMarginLeft = 0;
            this.btReserva.IconMarginRight = 0;
            this.btReserva.IconRightVisible = true;
            this.btReserva.IconRightZoom = 0D;
            this.btReserva.IconVisible = true;
            this.btReserva.IconZoom = 90D;
            this.btReserva.IsTab = false;
            this.btReserva.Location = new System.Drawing.Point(3, 203);
            this.btReserva.Name = "btReserva";
            this.btReserva.Normalcolor = System.Drawing.Color.Navy;
            this.btReserva.OnHovercolor = System.Drawing.Color.Blue;
            this.btReserva.OnHoverTextColor = System.Drawing.Color.White;
            this.btReserva.selected = false;
            this.btReserva.Size = new System.Drawing.Size(201, 48);
            this.btReserva.TabIndex = 6;
            this.btReserva.Text = "     Reservas";
            this.btReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReserva.Textcolor = System.Drawing.Color.White;
            this.btReserva.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReserva.Click += new System.EventHandler(this.btReserva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PrototipoHotel.Properties.Resources.Logo_Hotel;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btHabitaciones
            // 
            this.btHabitaciones.Activecolor = System.Drawing.Color.Transparent;
            this.btHabitaciones.BackColor = System.Drawing.Color.Navy;
            this.btHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHabitaciones.BorderRadius = 0;
            this.btHabitaciones.ButtonText = "     Habitaciones";
            this.btHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHabitaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btHabitaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btHabitaciones.Iconimage = global::PrototipoHotel.Properties.Resources.dias_festivos__1_2;
            this.btHabitaciones.Iconimage_right = null;
            this.btHabitaciones.Iconimage_right_Selected = null;
            this.btHabitaciones.Iconimage_Selected = null;
            this.btHabitaciones.IconMarginLeft = 0;
            this.btHabitaciones.IconMarginRight = 0;
            this.btHabitaciones.IconRightVisible = true;
            this.btHabitaciones.IconRightZoom = 0D;
            this.btHabitaciones.IconVisible = true;
            this.btHabitaciones.IconZoom = 90D;
            this.btHabitaciones.IsTab = false;
            this.btHabitaciones.Location = new System.Drawing.Point(3, 253);
            this.btHabitaciones.Name = "btHabitaciones";
            this.btHabitaciones.Normalcolor = System.Drawing.Color.Navy;
            this.btHabitaciones.OnHovercolor = System.Drawing.Color.Blue;
            this.btHabitaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btHabitaciones.selected = false;
            this.btHabitaciones.Size = new System.Drawing.Size(201, 48);
            this.btHabitaciones.TabIndex = 2;
            this.btHabitaciones.Text = "     Habitaciones";
            this.btHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHabitaciones.Textcolor = System.Drawing.Color.White;
            this.btHabitaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHabitaciones.Click += new System.EventHandler(this.btHabitaciones_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Activecolor = System.Drawing.Color.Transparent;
            this.btRegistrar.BackColor = System.Drawing.Color.Navy;
            this.btRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegistrar.BorderRadius = 0;
            this.btRegistrar.ButtonText = "     Registrar";
            this.btRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.btRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btRegistrar.Iconimage = global::PrototipoHotel.Properties.Resources.archivo2;
            this.btRegistrar.Iconimage_right = null;
            this.btRegistrar.Iconimage_right_Selected = null;
            this.btRegistrar.Iconimage_Selected = null;
            this.btRegistrar.IconMarginLeft = 0;
            this.btRegistrar.IconMarginRight = 0;
            this.btRegistrar.IconRightVisible = true;
            this.btRegistrar.IconRightZoom = 0D;
            this.btRegistrar.IconVisible = true;
            this.btRegistrar.IconZoom = 90D;
            this.btRegistrar.IsTab = false;
            this.btRegistrar.Location = new System.Drawing.Point(3, 307);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Normalcolor = System.Drawing.Color.Navy;
            this.btRegistrar.OnHovercolor = System.Drawing.Color.Blue;
            this.btRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btRegistrar.selected = false;
            this.btRegistrar.Size = new System.Drawing.Size(201, 48);
            this.btRegistrar.TabIndex = 3;
            this.btRegistrar.Text = "     Registrar";
            this.btRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegistrar.Textcolor = System.Drawing.Color.White;
            this.btRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btCheckout
            // 
            this.btCheckout.Activecolor = System.Drawing.Color.Transparent;
            this.btCheckout.BackColor = System.Drawing.Color.Navy;
            this.btCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckout.BorderRadius = 0;
            this.btCheckout.ButtonText = "     Check-Out";
            this.btCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheckout.DisabledColor = System.Drawing.Color.Gray;
            this.btCheckout.Iconcolor = System.Drawing.Color.Transparent;
            this.btCheckout.Iconimage = global::PrototipoHotel.Properties.Resources.dias_festivos;
            this.btCheckout.Iconimage_right = null;
            this.btCheckout.Iconimage_right_Selected = null;
            this.btCheckout.Iconimage_Selected = null;
            this.btCheckout.IconMarginLeft = 0;
            this.btCheckout.IconMarginRight = 0;
            this.btCheckout.IconRightVisible = true;
            this.btCheckout.IconRightZoom = 0D;
            this.btCheckout.IconVisible = true;
            this.btCheckout.IconZoom = 90D;
            this.btCheckout.IsTab = false;
            this.btCheckout.Location = new System.Drawing.Point(3, 149);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Normalcolor = System.Drawing.Color.Navy;
            this.btCheckout.OnHovercolor = System.Drawing.Color.Blue;
            this.btCheckout.OnHoverTextColor = System.Drawing.Color.White;
            this.btCheckout.selected = false;
            this.btCheckout.Size = new System.Drawing.Size(201, 48);
            this.btCheckout.TabIndex = 1;
            this.btCheckout.Text = "     Check-Out";
            this.btCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckout.Textcolor = System.Drawing.Color.White;
            this.btCheckout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Cerrar Sesión";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PrototipoHotel.Properties.Resources.web;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 460);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(201, 48);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "     Cerrar Sesión";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btReportes
            // 
            this.btReportes.Activecolor = System.Drawing.Color.Transparent;
            this.btReportes.BackColor = System.Drawing.Color.Navy;
            this.btReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportes.BorderRadius = 0;
            this.btReportes.ButtonText = "     Reportes";
            this.btReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btReportes.Iconimage = global::PrototipoHotel.Properties.Resources.datos2;
            this.btReportes.Iconimage_right = null;
            this.btReportes.Iconimage_right_Selected = null;
            this.btReportes.Iconimage_Selected = null;
            this.btReportes.IconMarginLeft = 0;
            this.btReportes.IconMarginRight = 0;
            this.btReportes.IconRightVisible = true;
            this.btReportes.IconRightZoom = 0D;
            this.btReportes.IconVisible = true;
            this.btReportes.IconZoom = 90D;
            this.btReportes.IsTab = false;
            this.btReportes.Location = new System.Drawing.Point(0, 361);
            this.btReportes.Name = "btReportes";
            this.btReportes.Normalcolor = System.Drawing.Color.Navy;
            this.btReportes.OnHovercolor = System.Drawing.Color.Blue;
            this.btReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btReportes.selected = false;
            this.btReportes.Size = new System.Drawing.Size(201, 48);
            this.btReportes.TabIndex = 4;
            this.btReportes.Text = "     Reportes";
            this.btReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportes.Textcolor = System.Drawing.Color.White;
            this.btReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportes.Click += new System.EventHandler(this.btReportes_Click);
            // 
            // btCheckin
            // 
            this.btCheckin.Activecolor = System.Drawing.Color.Transparent;
            this.btCheckin.BackColor = System.Drawing.Color.Navy;
            this.btCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckin.BorderRadius = 0;
            this.btCheckin.ButtonText = "     Check-In";
            this.btCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheckin.DisabledColor = System.Drawing.Color.Gray;
            this.btCheckin.Iconcolor = System.Drawing.Color.Transparent;
            this.btCheckin.Iconimage = global::PrototipoHotel.Properties.Resources.personas2;
            this.btCheckin.Iconimage_right = null;
            this.btCheckin.Iconimage_right_Selected = null;
            this.btCheckin.Iconimage_Selected = null;
            this.btCheckin.IconMarginLeft = 0;
            this.btCheckin.IconMarginRight = 0;
            this.btCheckin.IconRightVisible = true;
            this.btCheckin.IconRightZoom = 0D;
            this.btCheckin.IconVisible = true;
            this.btCheckin.IconZoom = 90D;
            this.btCheckin.IsTab = false;
            this.btCheckin.Location = new System.Drawing.Point(3, 95);
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.Normalcolor = System.Drawing.Color.Navy;
            this.btCheckin.OnHovercolor = System.Drawing.Color.Blue;
            this.btCheckin.OnHoverTextColor = System.Drawing.Color.White;
            this.btCheckin.selected = false;
            this.btCheckin.Size = new System.Drawing.Size(201, 48);
            this.btCheckin.TabIndex = 0;
            this.btCheckin.Text = "     Check-In";
            this.btCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckin.Textcolor = System.Drawing.Color.White;
            this.btCheckin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckin.Click += new System.EventHandler(this.btCheckin_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuUp);
            this.Controls.Add(this.panelMenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenuLeft.ResumeLayout(false);
            this.panelMenuUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btCheckin;
        private Bunifu.Framework.UI.BunifuFlatButton btCheckout;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton btReportes;
        public Bunifu.Framework.UI.BunifuFlatButton btRegistrar;
        public Bunifu.Framework.UI.BunifuFlatButton btHabitaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuLeft;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenuUp;
        private System.Windows.Forms.PictureBox btExpandir;
        private System.Windows.Forms.PictureBox btMinimizarMenu;
        private System.Windows.Forms.PictureBox btCerrarMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btReserva;
    }
}