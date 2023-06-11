using MushroomComparer_Third;

namespace MushroomComparer.Third
{
    public partial class Form1 : Form
    {
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            filePath = openFileDialog.FileName;
            var image = Image.FromFile(filePath);
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                return;

            //Load sample data
            var imageBytes = File.ReadAllBytes(filePath);
            Model.ModelInput sampleData = new Model.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var sortedScoresWithLabel = Model.PredictAllLabels(sampleData);

            //Display result
            //Display result
            //Result #1
            var result1 = sortedScoresWithLabel.ElementAt(0).Key;

            string prefix1 = result1.Substring(0, result1.LastIndexOf('-'));
            textBox1.Text = prefix1;

            string suffix1 = result1.Substring(result1.LastIndexOf('-') + 1);
            if (suffix1 == "Edible")
                textBox1.BackColor = Color.Green;
            if (suffix1 == "NotEdible")
                textBox1.BackColor = Color.Red;

            textBox2.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(0).Value);


            //Result #2
            var result2 = sortedScoresWithLabel.ElementAt(1).Key;

            string prefix2 = result2.Substring(0, result2.LastIndexOf('-'));
            textBox4.Text = prefix2;

            string suffix2 = result2.Substring(result2.LastIndexOf('-') + 1);
            if (suffix2 == "Edible")
                textBox4.BackColor = Color.Green;
            if (suffix2 == "NotEdible")
                textBox4.BackColor = Color.Red;

            textBox3.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(1).Value);


            //Result #3
            var result3 = sortedScoresWithLabel.ElementAt(2).Key;

            string prefix3 = result3.Substring(0, result3.LastIndexOf('-'));
            textBox6.Text = prefix3;

            string suffix3 = result3.Substring(result3.LastIndexOf('-') + 1);
            if (suffix3 == "Edible")
                textBox6.BackColor = Color.Green;
            if (suffix3 == "NotEdible")
                textBox6.BackColor = Color.Red;

            textBox5.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(2).Value);
        }
    }
}