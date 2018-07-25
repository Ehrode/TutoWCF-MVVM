using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using TutoWCFMVVM.ViewModels;

namespace TutoWCFMVVM
{
    public partial class CalculatorForm : MetroForm
    {
        private CalculatorViewModel myViewModel = new CalculatorViewModel();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ItemFinder_Load(object sender, EventArgs e)
        {
            var leftMemberBinding = new Binding("Text", myViewModel, "LeftMember", false, DataSourceUpdateMode.OnPropertyChanged);
            var rightMemberBinding = new Binding("Text", myViewModel, "RightMember", false, DataSourceUpdateMode.OnPropertyChanged);
            var resultMemberBinding = new Binding("Text", myViewModel, "OperationResult", false, DataSourceUpdateMode.OnPropertyChanged);
            var symbolActionBinding = new Binding("SelectedValue", myViewModel, "SelectedSymbolAction", true, DataSourceUpdateMode.OnPropertyChanged);

            metroTextBox1.DataBindings.Add(leftMemberBinding);
            metroTextBox2.DataBindings.Add(rightMemberBinding);
            metroTextBox3.DataBindings.Add(resultMemberBinding);

            // Data source est la liste d'objet qui va peupler la combobox
            metroComboBox1.DataSource = myViewModel.SymbolActionList;
            // Nom de la propiété qui porte la valeur à afficher dans la combobox
            metroComboBox1.DisplayMember = "Symbol";
            // on ajoute le binding tout comme pour les TextBox au dessus
            metroComboBox1.DataBindings.Add(symbolActionBinding);

            // Initialise l'objet séléctionner par défault pour éviter un appel à null au premier appel
            myViewModel.SelectedSymbolAction = myViewModel.SymbolActionList.FirstOrDefault();
        }

        
    }
}
