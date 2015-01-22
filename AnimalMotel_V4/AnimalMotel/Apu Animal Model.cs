//Ali Sabbagh zadeh 7307063458

using AnimalManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalMotel
{
    public partial class AnimalMotel : Form
    {
        List<Animal> animalList = new List<Animal>();
        Animal NewAnimal = new Animal();
        ValidationException showValidationMessage = new ValidationException();
        Helper helper = new Helper();
        private FileTypes m_fileExt = FileTypes.txt;
        private string m_fileName;
        private ProductManager m_productMngr;
        DataAccess DataAccess = new DataAccess();

        private void InitializeGUI()
        {
            m_productMngr = new ProductManager();
            m_fileName = "Untitled";
            //lblFileName.Text = string.Empty;
        }
        public AnimalMotel()
        {
            InitializeGUI();
            InitializeComponent();
            AddCategoriItemsInListBox();
            AddGenderInListBox();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
        }


        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chBoxAllAnimal.Checked && listBxCategori.SelectedItem != null)
            {

                listbxAnimalSpecies.Items.Clear();
                if (listBxCategori.SelectedItem.ToString() == CategoryType.Bird.ToString())
                {
                    AddBirdSpeciesTolistbxAnimalSpecies();
                    grBoxAnimalSpecifications.Text = "Bird Specifications";
                    grBoxAnimalSpecifications.Visible = true;
                    grBoxAnimalSpecifications.Enabled = false;
                }

                if (listBxCategori.SelectedItem.ToString() == CategoryType.Insect.ToString())
                {
                    AddInsectSpeciesTolistbxAnimalSpecies();
                    grBoxAnimalSpecifications.Text = "Insect Specifications";
                    grBoxAnimalSpecifications.Visible = true;
                    grBoxAnimalSpecifications.Enabled = false;
                }

                if (listBxCategori.SelectedItem.ToString() == CategoryType.Mammal.ToString())
                {
                    AddMammalSpeciesTolistbxAnimalSpecies();
                    grBoxAnimalSpecifications.Text = "Mammal Specifications";
                    grBoxAnimalSpecifications.Visible = true;
                    grBoxAnimalSpecifications.Enabled = true;
                }


                if (listBxCategori.SelectedItem.ToString() == CategoryType.Marine.ToString())
                {
                    AddMarineSpeciesTolistbxAnimalSpecies();
                    grBoxAnimalSpecifications.Text = "Marine Specifications";
                    grBoxAnimalSpecifications.Visible = true;
                    grBoxAnimalSpecifications.Enabled = false;
                }


                if (listBxCategori.SelectedItem.ToString() == CategoryType.Reptile.ToString())
                {
                    AddReptileSpeciesTolistbxAnimalSpecies();
                    grBoxAnimalSpecifications.Text = "Retile Specifications";
                    grBoxAnimalSpecifications.Visible = true;
                    grBoxAnimalSpecifications.Enabled = false;
                }
            }

        }

        private void AddReptileSpeciesTolistbxAnimalSpecies()
        {
            string[] names;
            names = Enum.GetNames(typeof(ReptileSpecies));
            for (int x = 0; x <= names.Length - 1; x++)
                listbxAnimalSpecies.Items.Add(names[x]);
        }

        private void AddMarineSpeciesTolistbxAnimalSpecies()
        {
            string[] names;
            names = Enum.GetNames(typeof(MarineSpecies));
            for (int x = 0; x <= names.Length - 1; x++)
                listbxAnimalSpecies.Items.Add(names[x]);
        }

        private void AddMammalSpeciesTolistbxAnimalSpecies()
        {
            string[] names;
            names = Enum.GetNames(typeof(MammalSpecies));
            for (int x = 0; x <= names.Length - 1; x++)
                listbxAnimalSpecies.Items.Add(names[x]);
        }

        private void AddInsectSpeciesTolistbxAnimalSpecies()
        {
            string[] names;
            names = names = Enum.GetNames(typeof(InsectSpecies));
            for (int x = 0; x <= names.Length - 1; x++)
                listbxAnimalSpecies.Items.Add(names[x]);
        }

        private void AddBirdSpeciesTolistbxAnimalSpecies()
        {
            string[] names;
            names = names = Enum.GetNames(typeof(BirdSpecies));
            for (int x = 0; x <= names.Length - 1; x++)
                listbxAnimalSpecies.Items.Add(names[x]);

        }

        private void AddGenderInListBox()
        {
            string[] names = Enum.GetNames(typeof(GenderType));

            for (int x = 0; x <= names.Length - 1; x++)
                listBxGender.Items.Add(names[x]);

        }
        private void AddCategoriItemsInListBox()
        {
            string[] names = Enum.GetNames(typeof(CategoryType));

            for (int x = 0; x <= names.Length - 1; x++)
                listBxCategori.Items.Add(names[x]);

        }

        private int CreateID(Animal newAnimal)
        {
            newAnimal.ID = listViewListOfRegisteredAnimals.Items.Count + 1;
            return newAnimal.ID;

        }

        private Animal CreateNewObject()
        {
            try
            {
                NewAnimal = SetAnimalType();
                if (NewAnimal != null)
                {
                    var nameAndAgeIScorrect = SetNameAndAge(NewAnimal);
                    if (nameAndAgeIScorrect)
                    {
                        NewAnimal.AnimalSpecificData();
                        CreateID(NewAnimal);
                        SetGenderType(NewAnimal);
                        SetAnimalSpecificData(NewAnimal);
                        SaveObject(NewAnimal);
                    }
                    else return NewAnimal = null;
                }
                else return NewAnimal = null;
            }
            catch (Exception e)
            {
                throw new ValidationException("Exception caught: {0}", e);
            }
            return NewAnimal;
        }

        private void SaveObject(Animal newAnimal)
        {

            animalList.Add(newAnimal);

        }
        private void SetAnimalSpecificData(Animal newAnimal)
        {
            newAnimal.GetAnimalSpecificData += String.IsNullOrEmpty(labBxImportantInfo.Text) ? newAnimal.GetAnimalSpecificData = "" : "Important info: " + labBxImportantInfo.Text;
        }


        private Animal SetAnimalType()
        {
            Animal newAnimal = new Animal();
            var selectedCategori = listBxCategori.SelectedIndex;

            if (string.IsNullOrEmpty(listbxAnimalSpecies.Text))
            {
                showValidationMessage.ShowNewMessageBox("Du måste välja djurarten från listan!");
                return newAnimal = null;
            }
            else
            {
                switch (selectedCategori)
                {
                    case 0:
                        BirdSpecies birdSpecies = (BirdSpecies)Enum.Parse(typeof(BirdSpecies), listbxAnimalSpecies.Text);
                        BirdFactory birdFactory = new BirdFactory();
                        newAnimal = birdFactory.Createbird(birdSpecies);
                        break;
                    case 1:
                        InsectSpecies insectSpecies = (InsectSpecies)Enum.Parse(typeof(InsectSpecies), listbxAnimalSpecies.Text);
                        InsectFactory insectFactory = new InsectFactory();
                        newAnimal = insectFactory.CreateInsect(insectSpecies);
                        break;

                    case 2:
                        MammalSpecies mammalSpecies = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listbxAnimalSpecies.Text);
                        MammalFactory mammalFactory = new MammalFactory();
                        int daysOfQuarantine;
                        int numberOfteeth;
                        bool underQuarantine = chBoxUnderQuarantine.Checked;
                        if (!helper.CheckInteger(texBoxDaysInQuarantine.Text, out daysOfQuarantine) && underQuarantine == true)
                        {
                            string messageDayOfQuarantine = "You have entered the error value in days of quarantine";
                            errorDayInQuarantiner.SetError(texBoxDaysInQuarantine, messageDayOfQuarantine);
                            showValidationMessage.ShowNewMessageBox(messageDayOfQuarantine);
                            newAnimal = null;
                            break;
                        }
                        else
                            errorDayInQuarantiner.Clear();
                        if (!int.TryParse(tboxNoOfTeeth.Text, out numberOfteeth))
                        {
                            errorNoOfTeeth.SetError(tboxNoOfTeeth, "You have entered the error value");
                            showValidationMessage.TeethException(tboxNoOfTeeth.Text);
                            newAnimal = null;
                            break;
                        }
                        else
                            errorNoOfTeeth.Clear();


                        newAnimal = mammalFactory.CreateMammal(mammalSpecies, daysOfQuarantine, underQuarantine, numberOfteeth);

                        break;

                    case 3:
                        MarineSpecies marineSpecies = (MarineSpecies)Enum.Parse(typeof(MarineSpecies), listbxAnimalSpecies.Text);
                        MarineFactory marineFactory = new MarineFactory();
                        newAnimal = marineFactory.CreateMarine(marineSpecies);
                        break;

                    case 4:
                        ReptileSpecies reptileSpecies = (ReptileSpecies)Enum.Parse(typeof(ReptileSpecies), listbxAnimalSpecies.Text);
                        ReptileFactory reptileFactory = new ReptileFactory();
                        newAnimal = reptileFactory.CreateReptile(reptileSpecies);
                        break;
                }
            }

            return newAnimal;

        }

        private bool SetNameAndAge(Animal newAnimal)
        {
            double age;
            bool animalHasWriteValue = true;
            string messageNamnAlder = "Du måste ange både namn och ålder";
            string messageFelAlder = "Du har anget fel år";
            if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbAge.Text))
            {
                if (string.IsNullOrEmpty(txbName.Text))
                {
                    errorPrName.SetError(txbName, messageNamnAlder);
                }
                if (string.IsNullOrEmpty(txbAge.Text))
                {
                    errorProAge.SetError(txbAge, messageFelAlder);
                }
                showValidationMessage.ShowNewMessageBox(messageNamnAlder);
                return animalHasWriteValue = false;
            }
            else
            {
                newAnimal.Name = txbName.Text;
                errorPrName.Clear();
            }
            if (helper.CheckDouble(txbAge.Text, out age))
            {
                newAnimal.Age = Convert.ToDouble(txbAge.Text);
                errorProAge.Clear();
            }
            else
            {
                errorProAge.SetError(txbAge, messageFelAlder);
                showValidationMessage.AgeException(txbAge.Text);
                return animalHasWriteValue = false;
            }

            return animalHasWriteValue;
        }



        private void SetGenderType(Animal newAnimal)
        {
            var selectedGender = listBxGender.SelectedIndex;
            newAnimal.GenderType = selectedGender == 0 ? newAnimal.GenderType = GenderType.Famale
                : selectedGender == 1 ? newAnimal.GenderType = GenderType.Male : newAnimal.GenderType = GenderType.Unknow;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            var newAnimal = CreateNewObject();
            if (NewAnimal != null)
            {
                try
                {
                    if (txbName.Text.Trim().Length > 0 && txbAge.Text.Trim().Length > 0)
                    {

                        listViewListOfRegisteredAnimals.Columns.Add("ID", 150);
                        listViewListOfRegisteredAnimals.Columns.Add("Name", 150);
                        listViewListOfRegisteredAnimals.Columns.Add("Age", 150);
                        listViewListOfRegisteredAnimals.Columns.Add("Gender", 150);
                        listViewListOfRegisteredAnimals.HeaderStyle = ColumnHeaderStyle.Clickable;
                        string[] row = { NewAnimal.ID.ToString(), txbName.Text, txbAge.Text, NewAnimal.GenderType.ToString() };
                        ListViewItem item = new ListViewItem(row);
                        listViewListOfRegisteredAnimals.Items.Add(item);

                    }
                    listBxSpecialData.Clear();
                    listBxSpecialData.Text = "Click on the row to view more information about the animals!";

                    ClearAllValue();


                }
                catch (Exception exc)
                {
                    throw (exc);
                }
            }
        }

        private void ClearAllValue()
        {
            txbName.Clear();
            txbAge.Clear();
            listBxGender.ClearSelected();
            listbxAnimalSpecies.ClearSelected();
            labBxImportantInfo.Clear();
            texBoxDaysInQuarantine.Clear();
            tboxNoOfTeeth.Clear();
        }

        private void selectRow_klick(object sender, EventArgs e)
        {
            listBxSpecialData.Clear();

            foreach (ListViewItem item in listViewListOfRegisteredAnimals.Items)
            {
                if (item.Selected == true)
                {
                    listBxSpecialData.Text = (animalList[item.Index].GetAnimalSpecificData.ToString());
                }
            }
        }

        private void Onclick_listAllAnimals(object sender, EventArgs e)
        {
            var lastSelect = listBxCategori.SelectedItem;
            listBxCategori.ClearSelected();

            if (chBoxAllAnimal.Checked)
            {
                ShowAllAnimals();
                listBxCategori.Enabled = false;
            }

            else
            {
                listbxAnimalSpecies.Items.Clear();
                listBxCategori.Enabled = true;
                listBxCategori.Items.Clear();
                AddCategoriItemsInListBox();

            }

        }

        private void ShowAllAnimals()
        {
            listbxAnimalSpecies.Items.Clear();
            AddBirdSpeciesTolistbxAnimalSpecies();
            AddInsectSpeciesTolistbxAnimalSpecies();
            AddMammalSpeciesTolistbxAnimalSpecies();
            AddMarineSpeciesTolistbxAnimalSpecies();
            AddReptileSpeciesTolistbxAnimalSpecies();

        }

        private void Click_ChooseCategoriFromList(object sender, EventArgs e)
        {
            if (chBoxAllAnimal.Checked)
                SelectedCategori();

        }
        private void SelectedCategori()
        {
            if (Enum.IsDefined(typeof(ReptileSpecies), listbxAnimalSpecies.SelectedItem.ToString()))
            {
                int index = listBxCategori.FindString(CategoryType.Reptile.ToString());
                listBxCategori.SelectedIndex = index;
                return;

            }
            if (Enum.IsDefined(typeof(MammalSpecies), listbxAnimalSpecies.SelectedItem.ToString()))
            {
                int index = listBxCategori.FindString(CategoryType.Mammal.ToString());
                listBxCategori.SelectedIndex = index;
                return;

            }
            if (Enum.IsDefined(typeof(BirdSpecies), listbxAnimalSpecies.SelectedItem.ToString()))
            {
                int index = listBxCategori.FindString(CategoryType.Bird.ToString());
                listBxCategori.SelectedIndex = index;
                return;

            }
            if (Enum.IsDefined(typeof(InsectSpecies), listbxAnimalSpecies.SelectedItem.ToString()))
            {
                int index = listBxCategori.FindString(CategoryType.Insect.ToString());
                listBxCategori.SelectedIndex = index;
                return;

            }
            if (Enum.IsDefined(typeof(MarineSpecies), listbxAnimalSpecies.SelectedItem.ToString()))
            {
                int index = listBxCategori.FindString(CategoryType.Marine.ToString());
                listBxCategori.SelectedIndex = index;
                return;

            }

        }

        private void chBoxUnderQuarantine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxUnderQuarantine.Checked)
            {
                texBoxDaysInQuarantine.Enabled = true;
            }
            else
                texBoxDaysInQuarantine.Enabled = false;
        }

        private void btnLoadPicture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "JPEG|*.jpg|Bitmaps|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pFileNames = openFileDialog.FileNames;
                var pCurrentImage = 0;
                ImageView(pFileNames, pCurrentImage);
            }
        }

        private void ImageView(string[] pFileNames, int pCurrentImage)
        {
            if (pCurrentImage >= 0 && pCurrentImage <= pFileNames.Length - 1)
            {
                picBox.Image = Bitmap.FromFile(pFileNames[pCurrentImage]);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_fileName))
                OpenFileToSaveData();
            else
            {
                string errorMsg = string.Empty;
                if (!m_productMngr.SaveDataToFile(m_fileName, m_fileExt, out errorMsg))
                    MessageBox.Show(errorMsg);
            }
        }
        private bool OpenFileToSaveData()
        {
            saveFileDialog.Title = "Sve file as " + m_fileExt.ToString();
            int filterIndex = 1;
            saveFileDialog.Filter = SetFileExtension(out filterIndex);

            saveFileDialog.FilterIndex = filterIndex;
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = Application.StartupPath;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m_fileName = saveFileDialog.FileName;  //important

                m_fileName = FileUtility.ChangeFileExtension(m_fileName, Enum.GetName(typeof(FileTypes), m_fileExt));
                string errorMsg = string.Empty;
                if (m_productMngr.SaveDataToFile(m_fileName, m_fileExt, out errorMsg))
                    //TODO:
                    //UpdateGUI();
                    // else
                    MessageBox.Show(errorMsg);

            }
            else
                return false;

            return true;
        }
        private string SetFileExtension(out int index)
        {
            const string filter = "dat files (*.dat) |*.dat|text files(*.txt)|*.txt|xml files (*.xml)|*.xml|all files (*.*) |*.*";

            switch (m_fileExt)
            {
                case FileTypes.dat:
                    index = 1;
                    break;
                case FileTypes.txt:
                    index = 2;
                    break;
                case FileTypes.xml:
                    index = 3;
                    break;
                default:
                    index = 4;
                    break;
            }
            return filter;
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewListOfRegisteredAnimals.Clear();

            listViewListOfRegisteredAnimals.Columns.Add("ID", 150);
            listViewListOfRegisteredAnimals.Columns.Add("Name", 150);
            listViewListOfRegisteredAnimals.Columns.Add("Age", 150);
            listViewListOfRegisteredAnimals.Columns.Add("Gender", 150);
            listViewListOfRegisteredAnimals.HeaderStyle = ColumnHeaderStyle.Clickable;

            
            ListView listView = DataAccess.LoadAnimalData();
            foreach (var item in listView.Items.Cast<ListViewItem>())
            {

                //ListView listViewItem = new ListView(item);
                //listViewListOfRegisteredAnimals.Items.Add(item);
                //ListViewSub asd = new ListViewItem();
                //asd.GetSubItemAt(item);
                listViewListOfRegisteredAnimals.Items.Add(item);
            }
            

        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql;

   

            for (int i = 0; i < listViewListOfRegisteredAnimals.Items.Count; i++)
            {
                Guid id = Guid.NewGuid();
                string name;
                int age = 0;
                string categori;
                string info = "";
                name = listViewListOfRegisteredAnimals.Items[i].SubItems[1].Text;
                age = Convert.ToInt32(listViewListOfRegisteredAnimals.Items[i].SubItems[2].Text);
                categori = listViewListOfRegisteredAnimals.Items[i].SubItems[3].Text;
                //info = string.IsNullOrEmpty(listViewListOfRegisteredAnimals.Items[i].SubItems[4].Text) ? string.Empty : listViewListOfRegisteredAnimals.Items[i].SubItems[4].Text;

                
                sql = "";
                sql = "INSERT INTO Animal (id,name,age,categori,info)"
                    + " VALUES ('" + id + "','" + name + "','" + age + "','" + categori + "','" + info + "')";

                DataAccess.SaveAnimalData(sql);
                //clsConnection clsCn = new clsConnection();
                //SqlConnection cn = null;
                //SqlCommand cmd = new SqlCommand();

                //clsCn.fnc_ConnectToDB(ref cn);

                //cmd.Connection = cn;
                //cmd.CommandText = sql;
                //cmd.ExecuteNonQuery();


                //this.Close();


            }
        }

    }
}


