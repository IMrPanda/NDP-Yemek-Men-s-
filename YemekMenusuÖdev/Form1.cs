using System.Windows.Forms;

namespace YemekMenusuÖdev
{
    public partial class Form1 : Form
    {
        private Menu m = new Menu();

        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde menü listesini gösteren metot
        private void Form1_Load(object sender, EventArgs e)
        {
            OrdersListBox.Items.Add(string.Format("{0,-15} {1,-10} {2,10} {3,5} {4,7} {5,-10}",
                                  "Name", "Type", "Price", "KDV", "Calorie", "Category"));
            OrdersListBox.Items.Add(new string('-', 76));
            UpdateTotalAmount();
        }

        // Toplam tutarı güncelleyen metot
        private void UpdateTotalAmount()
        {
            double subtotal = m.liste.Sum(f => f.Price);
            double totalKdv = m.liste.Sum(f => f.Price * f.KdvOrani);
            double total = subtotal + totalKdv;
            TotalLabel.Text = $"Ara Toplam: {subtotal:C2} + KDV: {totalKdv:C2} = Toplam: {total:C2}"; 
        }


        // Menüye yiyecek ekleyen buton
        private void AddMenuButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (!ValidateInputs()) return;

                Food newFood = CreateFoodItem();
                if (newFood == null) return;

                if (!ValidatePriceAndCalorie(newFood)) return;

                AddToMenu(newFood);
                ClearForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}", "ERROR",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the numerical values ​​accordingly!", "Incorrect Login",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "System Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            }

        // Formdaki giriş alanlarını kontrol eden metot
        private bool ValidateInputs()
        {
            // Yiyecek adı 
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowErrorMessage("Food name cannot be empty!", textBox1);
                textBox1.Focus();
                return false;
            }

            // Yiyecek türü 
            if (comboBox1.SelectedItem == null)
            {
                ShowErrorMessage("Please choose a food type!", comboBox1);
                return false;
            }

            // Fiyat 
            if (!double.TryParse(textBox3.Text, out double price) || price <= 0)
            {
                ShowErrorMessage("Please enter a valid price (must be greater than 0$)!", textBox3);
                textBox3.Focus();
                return false;
            }

            // Kalori 
            if (!double.TryParse(textBox5.Text, out double calorie) || calorie <= 0)
            {
                ShowErrorMessage("Please enter a valid calorie value (must be greater than 0)!", textBox5);
                textBox5.Focus();
                return false;
            }

            // KDV 
            if (!double.TryParse(textBox4.Text, out double kdv) || kdv < 0 || kdv > 1)
            {
                ShowErrorMessage("KDV rate must be between 0 and 1! (base value: 0.18)", textBox4);
                textBox4.Focus();
                return false;
            }

            return true;
        }


        // Formdaki giriş alanlarından yiyecek nesnesi oluşturan metot 
        private Food CreateFoodItem()
        {
            string name = textBox1.Text;
            string type = textBox2.Text;
            double price = Convert.ToDouble(textBox3.Text); 
            double kdv = Convert.ToDouble(textBox4.Text);   
            double calorie = Convert.ToDouble(textBox5.Text); 

            
            return comboBox1.SelectedItem.ToString() switch
            {
                "Fruit" => new Fruit(name, type, price, kdv, calorie),
                "Salad" => new Salad(name, type, price, kdv, calorie),
                "Dessert" => new Dessert(name, type, price, kdv, calorie),
                "Drinks" => new Drinks(name, type, price, kdv, calorie),
                _ => throw new ArgumentException("Invalid food type selected")
            };
        }

        private bool ValidatePriceAndCalorie(Food food)
        {
            if (food.Price >= 100 || food.Calorie >= 500)
            {
                MessageBox.Show("The price or calorie values ​​are not suitable!\n" +
                              "Price must be < 100 $ and Calories < 500 kcal.",
                              "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddToMenu(Food food)
        {
            m.Add(food);
            OrdersListBox.Items.Add(food.printout());
            UpdateTotalAmount();
            MessageBox.Show("Menu added successfully!", "INFO",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "0.18";
            textBox1.Focus();
        }

        private void ShowErrorMessage(string message, Control controlToFocus)
        {
            MessageBox.Show(message, "Incorrect Login",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            controlToFocus.Focus();
            if (controlToFocus is TextBox)
            {
                ((TextBox)controlToFocus).SelectAll();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedIndex > 0)
            {
                int selectedIndex = OrdersListBox.SelectedIndex;
                m.RemoveIndex(selectedIndex - 1);
                OrdersListBox.Items.RemoveAt(selectedIndex);
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select an item to remove!", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

