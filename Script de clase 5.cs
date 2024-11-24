		/* 
		 * ***********************
		 * CURSO C# INICIAL
		 * Parte 5 InterFaz Gráfica
		 * ***********************
		 */	
	
		// ------------------------
		// eventos para Hola Mundo
		// ------------------------

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hoy es un buen dia";
            label2.Text = textBox1.Text;
        }
		
		
		
		
		// --------------------------------		
		// eventos para gestion de usuarios
		// --------------------------------	
		
		
		        private void button1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            lblInformacion.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string usuario = txtUsuario.Text;
            //string clave = txtClave.Text;
            //if (usuario == "pepito" && clave == "educacionIT")
            //    lblInformacion.Text = "Bienvenido Pepito";
            //else
            //{
            //    if (usuario == "pepito")
            //        lblInformacion.Text = "Clave Incorrecta";
            //    else
            //        lblInformacion.Text = "Usuario Incorrecto";
            //}

            string[] usuarios = {"pepito","juan","laura","marcela"};
            string[] claves = {"educacionIT","123","abc","321"};
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            bool existe = false;
            int donde = 0;
            for (int a = 0; a < usuarios.Length; a++)
            {
                if (usuarios[a] == usuario)
                {
                    existe = true;
                    donde = a;
                }
            }
            if (existe)
            {
                if (claves[donde] == clave)
                    lblInformacion.Text = "Bienvenido " + usuario;
                else
                    lblInformacion.Text = "Clave Incorrecta";
            }
            else
                lblInformacion.Text = "Usuario Incorrecto";

				
			
			
			// ----------------------------------	
			// Eventos para la calculadora Básica
			// ----------------------------------
			
		private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtNum1.Text);
            int valor2 = int.Parse(txtNum2.Text);
            int operacion = valor1 + valor2;
            lblRes.Text = operacion.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtNum1.Text);
            int valor2 = int.Parse(txtNum2.Text);
            int operacion = valor1 - valor2;
            lblRes.Text = operacion.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtNum1.Text);
            int valor2 = int.Parse(txtNum2.Text);
            int operacion = valor1 * valor2;
            lblRes.Text = operacion.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtNum1.Text);
            int valor2 = int.Parse(txtNum2.Text);
            if (valor2 == 0)
                lblRes.Text = "Error División por 0";
            else
            {
                int operacion = valor1 / valor2;
                lblRes.Text = operacion.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblRes.Text = "";
        }
			
		
		
		
				
				