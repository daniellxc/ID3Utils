using Id3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3Utils
{
    public partial class Form1 : Form
    {
        #region Propriedades

        public DirectoryInfo DiretorioRaiz {
            get
            {
                if (Directory.Exists(txtDiretorioArquivos.Text))
                    return new DirectoryInfo(txtDiretorioArquivos.Text);
                return null;
            }
       
        }
        

        #endregion

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
             gbEditando.Visible = EscolherDiretorio(fbdRoot);

            if(DiretorioRaiz != null)
            {
                lblArquivosEncontrados.Text = DiretorioRaiz.GetFiles().Count().ToString() + " Arquivos encontrados.";

                if (!VerificarArquivosEncontrados())
                    Util.MensagemAlerta("Alguns arquivos não possuem Id3Tag válida. É recomendável preencher o campo com informações adicionais.");
            }
        }


        #region Métodos

        private bool EscolherDiretorio(FolderBrowserDialog _fbdRoot)
        {
            if(_fbdRoot.ShowDialog() == DialogResult.OK)
            {
                txtDiretorioArquivos.Text = _fbdRoot.SelectedPath;
                cmbSeparador.SelectedIndex = 0;
                return true;
            }else
            {
                txtDiretorioArquivos.ResetText();
                return false;
            }

            
        }

        private bool VerificarArquivosEncontrados()
        {
            if(DiretorioRaiz != null)
            {
                ArrayList fileErro = new ArrayList() ;

                foreach(FileInfo file in DiretorioRaiz.GetFiles())
                {
                    using(var mp3 = new Mp3File(file))
                    {
                        if(mp3.GetTag(Id3TagFamily.Version1x) == null)
                        {
                            fileErro.Add(file);
                        }
                    }

                }

                if(fileErro.Count > 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }


        private void RenomearArquivos()
        {
           if(DiretorioRaiz != null)
            {
                string artista, titulo, album, nome, separador, newPath, numero;
          
                int count = 0, max ;
                max = DiretorioRaiz.GetFiles().Count();


                try
                {
                    foreach (FileInfo file in DiretorioRaiz.GetFiles())
                    {

                        using (var mp3 = new Mp3File(file))
                        {
                            Id3Tag[] tag;
                           try
                            {
                               tag = mp3.GetAllTags();
                            }
                             catch(Exception ex)
                            {
                                throw ex;
                            }

                            Id3Tag tagReal;

                            nome = "";
                            if (tag.Count() > 0)
                            {

                                tagReal = tag[0];
                                if (ckNumeracao.Checked)
                                {
                                    count++;
                                    numero = count.ToString().PadLeft(max.ToString().Length, '0') + " ";
                                    nome = tagReal.Track.Value.ToString() != "0" && tagReal.Track.Value.ToString() != "" ? tagReal.Track.Value.ToString().PadLeft(max.ToString().Length, '0') + " " : numero;
                                }

                                separador = cmbSeparador.SelectedItem.ToString() != "" ? cmbSeparador.SelectedItem.ToString() : " - ";

                                artista = ckArtist.Checked ? tagReal.Artists : "";
                                titulo = ckTitle.Checked ? tagReal.Title : "";
                                album = ckAlbum.Checked ? tagReal.Album : "";


                                nome += album + (ckAlbum.Checked && ckArtist.Checked && artista != "" ? separador : "") +
                                       artista + (ckArtist.Checked && ckTitle.Checked && titulo != "" ? separador : "") +
                                       titulo + (ckTitle.Checked && txtExtra.Text != "" ? separador : "") +
                                       txtExtra.Text;



                            }
                            else
                            {
                                nome = txtExtra.Text;
                            }

                            newPath = DiretorioRaiz.FullName + "\\" + Util.TratarNomeArquivo(nome) + file.Extension;

                        }

                        if (!File.Exists(newPath))
                            File.Move(file.FullName, newPath);

                    }
                }
                catch (Exception ex)
                {
                    throw ex; 
                }
             

                }
            
        }

        #endregion

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            try
            {
                RenomearArquivos();
                Util.MensagemSucesso("Arquivos renomeados com sucesso!");
            }catch(Exception ex)
            {
                Util.MensagemErro("Ocorreu um erro durante a operação. Alguns arquivos podem não ter sido renomeados." + ex.Message);

            }
            
        }

      
    }
}
