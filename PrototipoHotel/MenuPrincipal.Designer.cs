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
            this.panelMenuUp = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btExpandir = new System.Windows.Forms.PictureBox();
            this.btMinimizarMenu = new System.Windows.Forms.PictureBox();
            this.btCerrarMenu = new System.Windows.Forms.PictureBox();
            this.panelMenuLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCheckout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCheckin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMenuUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).BeginInit();
            this.panelMenuLeft.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenuUp.Location = new System.Drawing.Point(210, 0);
            this.panelMenuUp.Name = "panelMenuUp";
            this.panelMenuUp.Quality = 10;
            this.panelMenuUp.Size = new System.Drawing.Size(678, 37);
            this.panelMenuUp.TabIndex = 1;
            // 
            // btExpandir
            // 
            this.btExpandir.Image = global::PrototipoHotel.Properties.Resources.Mobile_Menu_Icon;
            this.btExpandir.Location = new System.Drawing.Point(6, 3);
            this.btExpandir.Name = "btExpandir";
            this.btExpandir.Size = new System.Drawing.Size(25, 29);
            this.btExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExpandir.TabIndex = 40;
            this.btExpandir.TabStop = false;
            this.btExpandir.Click += new System.EventHandler(this.btExpandir_Click);
            // 
            // btMinimizarMenu
            // 
            this.btMinimizarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizarMenu.Image = global::PrototipoHotel.Properties.Resources.Btn_Minimizar;
            this.btMinimizarMenu.Location = new System.Drawing.Point(607, 3);
            this.btMinimizarMenu.Name = "btMinimizarMenu";
            this.btMinimizarMenu.Size = new System.Drawing.Size(25, 25);
            this.btMinimizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMinimizarMenu.TabIndex = 39;
            this.btMinimizarMenu.TabStop = false;
            this.btMinimizarMenu.Click += new System.EventHandler(this.btMinimizarMenu_Click);
            // 
            // btCerrarMenu
            // 
            this.btCerrarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.Image = global::PrototipoHotel.Properties.Resources.Btn_cerrar;
            this.btCerrarMenu.Location = new System.Drawing.Point(641, 3);
            this.btCerrarMenu.Name = "btCerrarMenu";
            this.btCerrarMenu.Size = new System.Drawing.Size(25, 25);
            this.btCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCerrarMenu.TabIndex = 38;
            this.btCerrarMenu.TabStop = false;
            this.btCerrarMenu.Click += new System.EventHandler(this.btCerrarMenu_Click);
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenuLeft.BackgroundImage")));
            this.panelMenuLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuLeft.Controls.Add(this.bunifuFlatButton1);
            this.panelMenuLeft.Controls.Add(this.btReportes);
            this.panelMenuLeft.Controls.Add(this.btRegistrar);
            this.panelMenuLeft.Controls.Add(this.btHabitaciones);
            this.panelMenuLeft.Controls.Add(this.btCheckout);
            this.panelMenuLeft.Controls.Add(this.btCheckin);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.GradientBottomLeft = System.Drawing.Color.Navy;
            this.panelMenuLeft.GradientBottomRight = System.Drawing.Color.Navy;
            this.panelMenuLeft.GradientTopLeft = System.Drawing.Color.Navy;
            this.panelMenuLeft.GradientTopRight = System.Drawing.Color.Navy;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Quality = 10;
            this.panelMenuLeft.Size = new System.Drawing.Size(210, 521);
            this.panelMenuLeft.TabIndex = 0;
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
            this.btReportes.Location = new System.Drawing.Point(3, 312);
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
            this.btRegistrar.Location = new System.Drawing.Point(3, 258);
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
            this.btHabitaciones.Location = new System.Drawing.Point(3, 204);
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
            this.btCheckout.Location = new System.Drawing.Point(3, 150);
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
            this.btCheckin.Location = new System.Drawing.Point(3, 96);
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
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(210, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(678, 484);
            this.panelContenedor.TabIndex = 2;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 461);
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
            this.panelMenuUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrarMenu)).EndInit();
            this.panelMenuLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelMenuLeft;
        private Bunifu.Framework.UI.BunifuFlatButton btCheckin;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenuUp;
        private Bunifu.Framework.UI.BunifuFlatButton btReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btRegistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btHabitaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btCheckout;
        private System.Windows.Forms.PictureBox btExpandir;
        private System.Windows.Forms.PictureBox btMinimizarMenu;
        private System.Windows.Forms.PictureBox btCerrarMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}