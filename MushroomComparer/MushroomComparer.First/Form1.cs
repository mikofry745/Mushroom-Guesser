using MushroomComparer_First;

namespace MushroomComparer.First
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
            textBox1.Text = sortedScoresWithLabel.ElementAt(0).Key;
            textBox2.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(0).Value);

            textBox4.Text = sortedScoresWithLabel.ElementAt(1).Key;
            textBox3.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(1).Value);

            textBox6.Text = sortedScoresWithLabel.ElementAt(2).Key;
            textBox5.Text = String.Format("{0:0.##\\ %}", sortedScoresWithLabel.ElementAt(2).Value);
        }
    }
}