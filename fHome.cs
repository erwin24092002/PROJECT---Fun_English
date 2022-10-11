using System.ComponentModel;
using System.Data;

namespace Game_mini
{
    public partial class fHome : Form
    {
        public DataTable data = new DataTable();

        public fHome()
        {
            InitializeComponent();
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 2;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fTopic f = new fTopic(data);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit the game?", "Announcement", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            fRank f = new fRank();
            f.ShowDialog();
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Topic", typeof(string));
            data.Columns.Add("En", typeof(string));
            data.Columns.Add("Vn", typeof(string));

            //Animals
            data.Rows.Add("Animals", "bear", "con gấu");
            data.Rows.Add("Animals", "bird", "con chim");
            data.Rows.Add("Animals", "cat", "con mèo");
            data.Rows.Add("Animals", "chicken", "con gà");
            data.Rows.Add("Animals", "cow", "con bò");
            data.Rows.Add("Animals", "dog", "con chó");
            data.Rows.Add("Animals", "elephant", "con voi");
            data.Rows.Add("Animals", "fish", "con cá");
            data.Rows.Add("Animals", "monkey", "con khỉ");
            data.Rows.Add("Animals", "tiger", "con hổ");

            //Clothing
            data.Rows.Add("Clothing", "belt", "thắc lưng");
            data.Rows.Add("Clothing", "boot", "giày ống");
            data.Rows.Add("Clothing", "coat", "ao khoác");
            data.Rows.Add("Clothing", "dress", "váy");
            data.Rows.Add("Clothing", "glasses", "mắt kính");
            data.Rows.Add("Clothing", "glove", "găng tay");
            data.Rows.Add("Clothing", "hat", "nón");
            data.Rows.Add("Clothing", "jeans", "quần jean");
            data.Rows.Add("Clothing", "pants", "quần dài");
            data.Rows.Add("Clothing", "scarf", "khăn choàng");
            data.Rows.Add("Clothing", "tie", "cà vạt");

            //Fruits 
            data.Rows.Add("Fruits", "apple", "quả táo");
            data.Rows.Add("Fruits", "banana", "quả chuối");
            data.Rows.Add("Fruits", "cherry", "quả anh đào");
            data.Rows.Add("Fruits", "coconut", "quả dừa");
            data.Rows.Add("Fruits", "grape", "quả nho");
            data.Rows.Add("Fruits", "lemon", "quả chanh");
            data.Rows.Add("Fruits", "mango", "quả xoài");
            data.Rows.Add("Fruits", "orange", "quả cam");
            data.Rows.Add("Fruits", "papaya", "quả đu đủ");
            data.Rows.Add("Fruits", "pear", "quả lê");
            data.Rows.Add("Fruits", "watermelon", "quả dưa hấu");

            //Plants 
            data.Rows.Add("Plants", "branch", "cành cây");
            data.Rows.Add("Plants", "bud", "mầm, chồi");
            data.Rows.Add("Plants", "bush", "bụi cây");
            data.Rows.Add("Plants", "flower", "hoa");
            data.Rows.Add("Plants", "grass", "cỏ");
            data.Rows.Add("Plants", "leaf", "lá cây");
            data.Rows.Add("Plants", "root", "rễ cây");
            data.Rows.Add("Plants", "seed", "hạt giống");
            data.Rows.Add("Plants", "thorn", "gai");
            data.Rows.Add("Plants", "tree", "cây");
            data.Rows.Add("Plants", "trunk", "thân cây");

            //Transportation
            data.Rows.Add("Transportation", "airport", "sân bay");
            data.Rows.Add("Transportation", "bicicle", "xe đạp");
            data.Rows.Add("Transportation", "boat", "thuyền");
            data.Rows.Add("Transportation", "bus", "xe buýt");
            data.Rows.Add("Transportation", "car", "xe ô tô");
            data.Rows.Add("Transportation", "motorbike", "xe máy");
            data.Rows.Add("Transportation", "plane", "máy bay");
            data.Rows.Add("Transportation", "road", "con đường");
            data.Rows.Add("Transportation", "ship", "tàu");
            data.Rows.Add("Transportation", "train", "tàu hoả");

            //Vegetables
            data.Rows.Add("Vegetables", "bean", "đậu");
            data.Rows.Add("Vegetables", "broccoli", "");
            data.Rows.Add("Vegetables", "cabbage", "");
            data.Rows.Add("Vegetables", "carrot", "cà rốt");
            data.Rows.Add("Vegetables", "celery", "");
            data.Rows.Add("Vegetables", "chili", "quả ớt");
            data.Rows.Add("Vegetables", "corn", "ngô");
            data.Rows.Add("Vegetables", "cucumber", "dưa leo");
            data.Rows.Add("Vegetables", "garlic", "tỏi");
            data.Rows.Add("Vegetables", "pumpkin", "bí ngô");
            data.Rows.Add("Vegetables", "tomato", "cà chua");

        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            fLearn f = new fLearn(data);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}