using CRUD_ENTITY.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ENTITY
{
    public partial class frmPersona : Form
    {
        PERSONA oPersonaEditar = null;
        public frmPersona(PERSONA oPersonaRecibida = null)
        {
           
            InitializeComponent();

            if (oPersonaRecibida != null)
            {
                oPersonaEditar = oPersonaRecibida;

                textoNombres.Text = oPersonaRecibida.Nombres;
                textoTelefono.Text = oPersonaRecibida.Telefono;
            }
        }


        private void frmPersona_Load(object sender, EventArgs e)
        {

        }


        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if(oPersonaEditar != null)
            {
                using (CN_DBPRUEBAS bd = new CN_DBPRUEBAS())
                {
                    PERSONA oPersonaParaEditar = (from seleccionado in bd.PERSONA
                                                  where seleccionado.IdPersona == oPersonaEditar.IdPersona
                                                  select seleccionado
                                                  ).FirstOrDefault();
                    oPersonaParaEditar.Nombres = textoNombres.Text;
                    oPersonaParaEditar.Telefono = textoTelefono.Text;

                    bd.SaveChanges();
                }


            }
            else
            {
                using (CN_DBPRUEBAS bd = new CN_DBPRUEBAS())
                {
                    bd.PERSONA.Add(new PERSONA()
                    {
                        Nombres = textoNombres.Text,
                        Telefono = textoTelefono.Text

                    });

                    bd.SaveChanges();
                }
            }

            

            this.Close();
        }

        
    }
}
