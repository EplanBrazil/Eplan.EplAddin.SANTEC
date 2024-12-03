using Eplan.EplAddin.Empty.PartsManagement;
using Eplan.EplAddin.Empty.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Eplan.EplAddin.Santec
{
    public partial class PartsManagementForm : MaterialForm
    {
        private IEnumerable<XElement> _xmlGroups;
        private string _cod_01_03;
        private string _cod_04_07;
        private string _cod_08_09;

        // Código completo do item
        private string _item_cod;

        // Lista para guardar os componentes(TextBox de entrada do digitos 10 a 13
        private List<TextBoxOptions> _cod_10to13_inputComponents;

        // Lista para rastrear linhas adicionadas dinamicamente (Panel, Label, InputControl)
        private List<(FlowLayoutPanel Panel, MaterialLabel Label, Control InputControl)> _addedExtraRowList;

        public PartsManagementForm()
        {
            InitializeComponent();
            InitializeData();
            AttachEventHandlers();
            LoadComboxBox1();
        }

        private void InitializeData()
        {
            _addedExtraRowList = new List<(FlowLayoutPanel, MaterialLabel, Control)>();
            _cod_10to13_inputComponents = new List<TextBoxOptions>();
            _xmlGroups = ReadItemListXml.GetXmlGroups();
            _item_cod = String.Concat(Enumerable.Repeat("0", 13)); // Incia os 13 digítos com 0 para ser manipulado durante a execução
        }

        private void AttachEventHandlers()
        {
            okButton.Click += OkButton_Click;                                                       // Evento para o botão OK
            cancelButton.Click += CancelButton_Click;                                               // Evento para o botão Cancelar
            digits1to3ComboBox.SelectedIndexChanged += Digits1to3ComboBox_SelectedIndexChanged;     // Evento para mudança no ComboBox 1 a 3 
            digits4to7ComboBox.SelectedIndexChanged += Digits4to7ComboBox_SelectedIndexChanged;     // Evento para mudança no ComboBox 4 a 7
            digits8to9ComboBox.SelectedIndexChanged += Digits8to9ComboBox_SelectedIndexChanged;     // Evento para mudança no ComboBox 8 a 9
        }

        private void LoadComboxBox1()
        {
            var group_01_03 = _xmlGroups
                .FirstOrDefault(g => (string)g.Attribute("id") == "cod_01_03");

            if (group_01_03 != null)
            {
                LoadComboBoxItens(group_01_03, "option", digits1to3ComboBox);
            }

        }

        private void Digits1to3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item obj = digits1to3ComboBox.SelectedItem as Item;
            _cod_01_03 = obj.Id;

            // Limpa os próximos campos
            RemoveExtraRows();
            digits8to9ComboBox.Items.Clear();
            digits4to7ComboBox.Items.Clear();
            itemDescriptionTextBox.Text = string.Empty;

            // Bloqueia alguns campos específicos
            itemDescriptionTextBox.Enabled = false;
            digits8to9ComboBox.Enabled = false;

            // Atribui valor para o código do item
            string lastCodes = _item_cod.Substring(3, 10); // Pega os proximos codigos, após o cod_1to3
            _item_cod = _cod_01_03 + lastCodes;
            itemCodeTextBox.Text = _cod_01_03;

            LoadComboxBox2();
        }

        private void LoadComboxBox2()
        {
            var group_cod_04_07 = _xmlGroups
                .FirstOrDefault(g => (string)g.Attribute("id") == "cod_04_07");

            if (group_cod_04_07 != null)
            {
                var group_cod_04_07_requirement =
                    group_cod_04_07.Descendants("requirement")
                    .FirstOrDefault(r => (string)r.Attribute("req_01_03") == _cod_01_03);

                if (group_cod_04_07_requirement != null)
                {
                    LoadComboBoxItens(group_cod_04_07_requirement, "option", digits4to7ComboBox);
                    digits4to7ComboBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Não tem {_cod_01_03} na req cod_01_03");
                    digits4to7ComboBox.Enabled = false;
                    digits8to9ComboBox.Enabled = false;
                }

            }
        }

        private void Digits4to7ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item obj = digits4to7ComboBox.SelectedItem as Item;
            _cod_04_07 = obj.Id;

            // Limpa os próximos campos
            RemoveExtraRows();
            digits8to9ComboBox.Items.Clear();

            itemDescriptionTextBox.Enabled = false;

            // Atribui o valor para o código do item
            string firstCodes = _item_cod.Substring(0, 3);  // Pega os codigos anterios ao cod_4to7
            string lastCodes = _item_cod.Substring(7, 6); // Pega os proximos codigos ao cod_4to7
            _item_cod = firstCodes + _cod_04_07 + lastCodes;
            itemCodeTextBox.Text = firstCodes + _cod_04_07;

            // Atribui o valor para a descrição do item
            itemDescriptionTextBox.Text = obj.Name;

            LoadComboxBox3();
        }

        private void LoadComboxBox3()
        {
            var group_cod_08_09 = _xmlGroups
                .FirstOrDefault(g => (string)g.Attribute("id") == "cod_08_09");

            if (group_cod_08_09 != null)
            {
                var group_cod_08_09_requirements_01_03 = group_cod_08_09
                    .Descendants("requirement")
                    .Where(r => r.Attribute("req_01_03") != null);

                XElement group_cod_08_09_requirement_01_03 = FindRequirement(group_cod_08_09_requirements_01_03, "req_01_03", _cod_01_03);

                if (group_cod_08_09_requirement_01_03 != null)
                {
                    var group_cod_08_09_requirements_04_07 = group_cod_08_09_requirement_01_03
                        .Descendants("requirement")
                        .Where(r => r.Attribute("req_04_07") != null);

                    XElement group_cod_08_09_requirement_04_07 = FindRequirement(group_cod_08_09_requirements_04_07, "req_04_07", _cod_04_07);

                    if (group_cod_08_09_requirement_04_07 != null)
                    {
                        LoadComboBoxItens(group_cod_08_09_requirement_04_07, "option", digits8to9ComboBox);
                    }
                }
                digits8to9ComboBox.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Não tem {_cod_01_03} na req cod_08_09");
                digits8to9ComboBox.Enabled = false;
            }
        }

        private void Digits8to9ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item obj = digits8to9ComboBox.SelectedItem as Item;
            _cod_08_09 = obj.Id;

            RemoveExtraRows();

            // Atribui o valor para o código do item
            string firstCodes = _item_cod.Substring(0, 7);  // Pega os codigos anterios ao cod_8to9
            string lastCodes = _item_cod.Substring(9, 4); // Pega os proximos codigos ao cod_8to9
            _item_cod = firstCodes + _cod_08_09 + lastCodes;
            itemCodeTextBox.Text = firstCodes + _cod_08_09;

            // Atribui o valor para a descrição do item
            itemDescriptionTextBox.Text += $" - {obj.Name}";
            itemDescriptionTextBox.Enabled = true;

            LoadComponents10to13();
        }

        private void LoadComponents10to13()
        {
            MessageBox.Show("cod 01 a 03: " + _cod_01_03);
            MessageBox.Show("cod 04 a 07: " + _cod_04_07);
            MessageBox.Show("cod 08 a 09: " + _cod_08_09);
            var group_cod_10_13 = _xmlGroups
                .FirstOrDefault(g => (string)g.Attribute("id") == "cod_10_13");
            if (group_cod_10_13 != null)
            {
                var group_cod_10_13_requirements_01_03 = group_cod_10_13
                    .Descendants("requirement")
                    .Where(r => r.Attribute("req_01_03") != null);

                XElement group_cod_10_13_requirement_01_03 = FindRequirement(group_cod_10_13_requirements_01_03, "req_01_03", _cod_01_03);

                if (group_cod_10_13_requirement_01_03 != null)
                {
                    var group_cod_10_13_requirements_04_07 = group_cod_10_13_requirement_01_03
                        .Descendants("requirement")
                        .Where(r => r.Attribute("req_04_07") != null);

                    XElement group_cod_10_13_requirement_04_07 = FindRequirement(group_cod_10_13_requirements_04_07, "req_04_07", _cod_04_07);

                    if (group_cod_10_13_requirement_04_07 != null)
                    {
                        InputType inputType = FindInputType(group_cod_10_13_requirement_04_07.Descendants("item").First());
                        CreateInputTypes(group_cod_10_13_requirement_04_07, inputType);
                    }

                    else
                    {
                        MessageBox.Show($"Não tem {_cod_04_07} na req cod_10_13 do req_01_03 = {_cod_01_03}");
                        RemoveExtraRows();
                    }
                }
            }
            digits8to9ComboBox.Enabled = true;
        }

        private InputType FindInputType(XElement element)
        {
            return (InputType)Enum.Parse(typeof(InputType), (string)element.Attribute("type"));
        }

        // Lógica para adicionar os componentes do digito 10 a 13 no formulário
        private void CreateInputTypes(XElement group, InputType type)
        {
            var group_options = group.Descendants("item");

            // o type é TextBox
            if (type == InputType.input)
            {
                foreach (XElement item in group_options.Elements("input"))
                {
                    string inputName = item.Attribute("name")?.Value;
                    int inputLength = int.Parse(item.Attribute("length")?.Value);
                    string alignmentLeft = item.Attribute("alignment")?.Value;

                    (FlowLayoutPanel Panel, MaterialLabel Label, MaterialTextBox InputControl) createdRow = AddExtraRow<MaterialTextBox>(components =>
                    {
                        components.Panel.AutoSize = true;
                        components.Label.Dock = DockStyle.Left;
                        components.Label.Text = inputName;
                        components.InputControl.Width = 250;
                        components.InputControl.UseTallSize = false;
                        components.InputControl.MaxLength = 1000;
                        components.InputControl.Name = $"{inputName}TextBox";
                    });
                    createdRow.InputControl.TextChanged += Value_10to13_Changed;
                    TextBoxOptions textBoxOptions = new TextBoxOptions()
                    {
                        MaterialTextBox = createdRow.InputControl,
                        Length = inputLength,
                        IsAlignmentLeft = alignmentLeft == null ? false : true
                    };
                    _cod_10to13_inputComponents.Add(textBoxOptions);
                }
            }
            // o type é ComboBox
            else if (type == InputType.list)
            {
                (FlowLayoutPanel Panel, MaterialLabel Label, MaterialComboBox InputControl) createdRow = AddExtraRow<MaterialComboBox>(components =>
                {
                    components.Panel.AutoSize = true;
                    components.Label.Dock = DockStyle.Left;
                    components.Label.Text = "Código 10 a 13";
                    components.InputControl.Width = 250;

                    components.InputControl.Name = $"digits10to13comboBox";
                });
                createdRow.InputControl.SelectedIndexChanged += Value_10to13_Changed;

                LoadComboBoxItens(group, "option", createdRow.InputControl);

            }
        }

        private void Value_10to13_Changed(object sender, EventArgs e)
        {
            if (sender is MaterialTextBox)
            {
                MaterialTextBox materialTextBox = sender as MaterialTextBox;
                TextBoxOptions textBoxOptions = _cod_10to13_inputComponents.Where(textBox => textBox.MaterialTextBox.Name == materialTextBox.Name).First();

                int textBoxIndex = 0;   // Guarda o indíce do digito no digito 10 a 13
                int textBoxAmount = _cod_10to13_inputComponents.Count;  // Guarda a quantidade de textBox para o codigo de 10 a 13
                foreach (TextBoxOptions textBoxOption in _cod_10to13_inputComponents)
                {
                    if (materialTextBox.Name == textBoxOption.MaterialTextBox.Name)
                    {
                        textBoxIndex = _cod_10to13_inputComponents.IndexOf(textBoxOption);
                    }
                }
             
                string textBoxNumbers = FindNumbersFromString(textBoxOptions.MaterialTextBox.Text); // Recupera os números presentes no textBox
                string code;

                if (textBoxNumbers.Length < textBoxOptions.Length)
                {
                    int zeroQuantity = textBoxOptions.Length - textBoxNumbers.Length;
                    string zeros = String.Concat(Enumerable.Repeat("0", zeroQuantity));
                    code = string.Empty;

                    if (textBoxOptions.IsAlignmentLeft == true)
                    {
                        code = textBoxNumbers + zeros;
                    } 
                    else
                    {
                        code = zeros + textBoxNumbers;
                    }

                    ChangeDigits10to13(textBoxOptions.Length, textBoxIndex, textBoxAmount, code);
                    return;
                }

                if (textBoxNumbers.Length > textBoxOptions.Length)
                {
                    code = textBoxNumbers.Substring(0, textBoxOptions.Length);
                    ChangeDigits10to13(textBoxOptions.Length, textBoxIndex, textBoxAmount, code);
                    return;
                }

                // Tamanho da entrada é o mesmo do requisito
                code = textBoxNumbers;
                ChangeDigits10to13(textBoxOptions.Length, textBoxIndex, textBoxAmount, code);
                return;
            }

            if (sender is MaterialComboBox)
            {
                MaterialComboBox comboBox = sender as MaterialComboBox;
                string firstCodes = _item_cod.Substring(0, 9);
                Item obj = comboBox.SelectedItem as Item;
                _item_cod = firstCodes + obj.Id;
                itemCodeTextBox.Text = _item_cod;
            }
        }

        private string FindNumbersFromString(string value)
        {
            string numbers = string.Empty;
            foreach (char c in value)
            {
                if (char.IsDigit(c)) numbers += c;
            }
            return numbers;
        }

        private void ChangeDigits10to13(int codePartLength, int index, int totalIndexes, string code)
        {
            // O codePartLength representa a quantidade de números do input no codigo 10 a 13

            string firstCodes = _item_cod.Substring(0, 9);

            if (codePartLength == 2)
            {
                if (index == 0)
                {
                    string partAfterIndex = _item_cod.Substring(11, 2);
                    _item_cod = firstCodes + code + partAfterIndex;
                    itemCodeTextBox.Text = _item_cod;
                    return;
                }

                if (index == 1)
                {
                    if (totalIndexes == 2)
                    {
                        string partBeforeIndex = _item_cod.Substring(9, 2);
                        _item_cod = firstCodes + partBeforeIndex + code;
                        itemCodeTextBox.Text = _item_cod;
                        return;
                    }

                    if (totalIndexes == 3)
                    {
                        string partBeforeIndex = _item_cod.Substring(9, 1);
                        string partAfterIndex = _item_cod.Substring(12, 1);
                        _item_cod = firstCodes + partBeforeIndex + code + partAfterIndex;
                        itemCodeTextBox.Text = _item_cod;
                        return;
                    }
                }

                if (index == 2)
                {
                    string partBeforeIndex = _item_cod.Substring(9, 2);
                    _item_cod = firstCodes + partBeforeIndex + code;
                    itemCodeTextBox.Text = _item_cod;
                    return;
                }
            }

            // Lógica para outros casos (outros tamanhos de codePartLength)
            int startIndex = 9 + index;
            int endIndex = startIndex + codePartLength;

            string partBefore = _item_cod.Substring(9, index);
            string partAfter = _item_cod.Substring(endIndex);

            _item_cod = firstCodes + partBefore + code + partAfter;

            itemCodeTextBox.Text = _item_cod;

        }

        private XElement FindRequirement(IEnumerable<XElement> group_requirements, string attribute, string code)
        {
            foreach (var requirement in group_requirements)
            {
                string requirementValue = (string)requirement.Attribute(attribute);

                // Confere se contém "," entre os números
                if (requirementValue.Contains(","))
                {
                    string[] requirement_numbers = requirementValue.Split(',');

                    foreach (string number in requirement_numbers)
                    {
                        // Se o número tem o formato de intervalo (110-116)
                        if (number.Contains("-"))
                        {
                            string[] range = number.Split('-');
                            if (range.Length == 2 && int.TryParse(range[0], out int inicialNumber) && int.TryParse(range[1], out int finalNumber))
                            {
                                if (int.TryParse(code, out int code_int) && code_int >= inicialNumber && code_int <= finalNumber) return requirement;
                            }
                        }
                        else
                        {
                            if (int.TryParse(number, out int singleNumber) && int.TryParse(code, out int cod) && singleNumber == cod) return requirement;
                        }
                    }
                }
                // Se não tiver "," mas tiver "-"
                else if (requirementValue.Contains("-"))
                {
                    string[] range = requirementValue.Split('-');
                    if (range.Length == 2 && int.TryParse(range[0], out int inicialNumber) && int.TryParse(range[1], out int finalNumber))
                    {
                        if (int.TryParse(code, out int code_int) && code_int >= inicialNumber && code_int <= finalNumber) return requirement;
                    }
                }
                // Se não tiver "," e não tiver "-", verifica se o valor é igual
                else if (int.TryParse(requirementValue, out int singleValue) && int.TryParse(code, out int code_int) && singleValue == code_int)
                {
                    return requirement;
                }
            }
            return null;
        }

        // Carrega os itens no ComboBox
        private void LoadComboBoxItens(XElement group, string element, ComboBox comboBox)
        {
            var group_options = group.Descendants("item");
            foreach (XElement item in group_options.Elements((element)))
            {
                string value = item.Attribute("id")?.Value;
                string display = item.Attribute("name")?.Value;

                comboBox.Items.Add(new Item()
                {
                    Id = value,
                    Name = display,
                });
            }
        }

        // Adiciona uma nova linha com um label e um controle de entrada do tipo T
        private (FlowLayoutPanel Panel, MaterialLabel Label, T InputControl) AddExtraRow<T>(
        Action<(FlowLayoutPanel Panel, MaterialLabel Label, T InputControl)> configureRow) where T : Control, new()
        {
            var panel = new FlowLayoutPanel();                      // Contêiner da linha
            var label = new MaterialLabel();                        // Label da linha
            var inputControl = new T();                             // Controle de entrada (genérico)

            configureRow?.Invoke((panel, label, inputControl));     // Personaliza o layout da linha

            panel.Controls.Add(label);                              // Adiciona o label à linha
            panel.Controls.Add(inputControl);                       // Adiciona o controle de entrada à linha
            this.topFlowLayoutPanel.Controls.Add(panel);            // Adiciona a linha ao painel pai

            _addedExtraRowList.Add((panel, label, inputControl));   // Rastreia a linha
            return (panel, label, inputControl);
        }

        // Remove todas as linhas adicionadas dinamicamente
        private void RemoveExtraRows()
        {
            foreach (var row in _addedExtraRowList)
            {
                this.topFlowLayoutPanel.Controls.Remove(row.Panel); // Remove do painel pai
                row.Panel.Dispose();                           // Libera os recursos
            }
            _addedExtraRowList.Clear(); // Limpa a lista de rastreamento
            _cod_10to13_inputComponents.Clear(); // Limpa a lista de inputComponents
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void OkButton_Click(object sender, EventArgs e) 
        {
            if (itemCodeTextBox.Text.Length < 13)
            {
                MessageBox.Show("Informe todos os valores!", "Gerenciamento de itens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}