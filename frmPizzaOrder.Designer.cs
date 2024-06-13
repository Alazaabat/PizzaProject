using PizzaProject.Enums;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace PizzaProject
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
    
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitLists()
        {


            this.sizeRadioButtons.Add(rbSmallSize);
            this.sizeRadioButtons.Add(rbMediumSize);
            this.sizeRadioButtons.Add(rbLargeSize);
            this.crustRadioButtons.Add(rbThinCrust);
            this.sizeRadioButtons.Add(rbMediumCrust);
            this.sizeRadioButtons.Add(rbThickCrust);
            this.toppingsCheckBoxButtons.Add(chkExtraCheese);
            this.toppingsCheckBoxButtons.Add(chkMushrooms);
            this.toppingsCheckBoxButtons.Add(chkTomatoes);
            this.toppingsCheckBoxButtons.Add(chkOlives);
            this.toppingsCheckBoxButtons.Add(chkOnion);
            this.toppingsCheckBoxButtons.Add(chkPeppers);
            this.eatPlaceRadioButtons.Add(rbTakeOut);
            this.eatPlaceRadioButtons.Add(rbOnTable);
            this.groupBoxes.Add(gbPizzaSize);
            this.groupBoxes.Add(gbCrustType);
            this.groupBoxes.Add(gbToppings);
            this.groupBoxes.Add(gbPizzaOrderPlace);
            this.groupBoxes.Add(gbOrderSummary);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLargeSize = new System.Windows.Forms.RadioButton();
            this.rbMediumSize = new System.Windows.Forms.RadioButton();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblResultToppings = new System.Windows.Forms.TextBox();
            this.lblResultEatPlace = new System.Windows.Forms.Label();
            this.lblResultCrust = new System.Windows.Forms.Label();
            this.lblResultSize = new System.Windows.Forms.Label();
            this.lblResultTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOrderSummaryEatPlace = new System.Windows.Forms.Label();
            this.lblOrderSummaryCrust = new System.Windows.Forms.Label();
            this.lblOrderSummaryToppings = new System.Windows.Forms.Label();
            this.lblOrderSummarySize = new System.Windows.Forms.Label();
            this.gbPizzaOrderPlace = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbOnTable = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbMediumCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.lblPizzaMake = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Button();
            this.btnRestForm = new System.Windows.Forms.Button();
            this.gbPizzaSize.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbPizzaOrderPlace.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaSize.Controls.Add(this.rbLargeSize);
            this.gbPizzaSize.Controls.Add(this.rbMediumSize);
            this.gbPizzaSize.Controls.Add(this.rbSmallSize);
            this.gbPizzaSize.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.ForeColor = System.Drawing.Color.Orange;
            this.gbPizzaSize.Location = new System.Drawing.Point(235, 179);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(215, 176);
            this.gbPizzaSize.TabIndex = 0;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbLargeSize
            // 
            this.rbLargeSize.AutoSize = true;
            this.rbLargeSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbLargeSize.Location = new System.Drawing.Point(18, 123);
            this.rbLargeSize.Name = "rbLargeSize";
            this.rbLargeSize.Size = new System.Drawing.Size(110, 46);
            this.rbLargeSize.TabIndex = 2;
            this.rbLargeSize.Text = "Large";
            this.rbLargeSize.UseVisualStyleBackColor = true;
            this.rbLargeSize.CheckedChanged += new System.EventHandler(this.rbLargeSize_CheckedChanged);
            // 
            // rbMediumSize
            // 
            this.rbMediumSize.AutoSize = true;
            this.rbMediumSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbMediumSize.Location = new System.Drawing.Point(18, 79);
            this.rbMediumSize.Name = "rbMediumSize";
            this.rbMediumSize.Size = new System.Drawing.Size(141, 46);
            this.rbMediumSize.TabIndex = 1;
            this.rbMediumSize.Text = "Medium";
            this.rbMediumSize.UseVisualStyleBackColor = true;
            this.rbMediumSize.CheckedChanged += new System.EventHandler(this.rbMediumSize_CheckedChanged);
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbSmallSize.Location = new System.Drawing.Point(18, 35);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(111, 46);
            this.rbSmallSize.TabIndex = 0;
            this.rbSmallSize.Text = "Small";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.lblResultToppings);
            this.gbOrderSummary.Controls.Add(this.lblResultEatPlace);
            this.gbOrderSummary.Controls.Add(this.lblResultCrust);
            this.gbOrderSummary.Controls.Add(this.lblResultSize);
            this.gbOrderSummary.Controls.Add(this.lblResultTotal);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryEatPlace);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryCrust);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryToppings);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummarySize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Orange;
            this.gbOrderSummary.Location = new System.Drawing.Point(983, 60);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(217, 539);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblResultToppings
            // 
            this.lblResultToppings.Location = new System.Drawing.Point(8, 189);
            this.lblResultToppings.Multiline = true;
            this.lblResultToppings.Name = "lblResultToppings";
            this.lblResultToppings.ReadOnly = true;
            this.lblResultToppings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblResultToppings.Size = new System.Drawing.Size(197, 61);
            this.lblResultToppings.TabIndex = 8;
            this.lblResultToppings.Text = "None";
            // 
            // lblResultEatPlace
            // 
            this.lblResultEatPlace.AutoSize = true;
            this.lblResultEatPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblResultEatPlace.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResultEatPlace.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultEatPlace.Location = new System.Drawing.Point(95, 337);
            this.lblResultEatPlace.Name = "lblResultEatPlace";
            this.lblResultEatPlace.Size = new System.Drawing.Size(117, 43);
            this.lblResultEatPlace.TabIndex = 9;
            this.lblResultEatPlace.Text = "OnTable";
            // 
            // lblResultCrust
            // 
            this.lblResultCrust.AutoSize = true;
            this.lblResultCrust.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.lblResultCrust.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultCrust.Location = new System.Drawing.Point(98, 253);
            this.lblResultCrust.Name = "lblResultCrust";
            this.lblResultCrust.Size = new System.Drawing.Size(72, 42);
            this.lblResultCrust.TabIndex = 8;
            this.lblResultCrust.Text = "Thin";
            // 
            // lblResultSize
            // 
            this.lblResultSize.AutoSize = true;
            this.lblResultSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.lblResultSize.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultSize.Location = new System.Drawing.Point(94, 99);
            this.lblResultSize.Name = "lblResultSize";
            this.lblResultSize.Size = new System.Drawing.Size(86, 42);
            this.lblResultSize.TabIndex = 6;
            this.lblResultSize.Text = "Small";
            // 
            // lblResultTotal
            // 
            this.lblResultTotal.AutoSize = true;
            this.lblResultTotal.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTotal.ForeColor = System.Drawing.Color.Orange;
            this.lblResultTotal.Location = new System.Drawing.Point(89, 438);
            this.lblResultTotal.Name = "lblResultTotal";
            this.lblResultTotal.Size = new System.Drawing.Size(81, 71);
            this.lblResultTotal.TabIndex = 5;
            this.lblResultTotal.Text = "0$";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 398);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(122, 54);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total :";
            // 
            // lblOrderSummaryEatPlace
            // 
            this.lblOrderSummaryEatPlace.AutoSize = true;
            this.lblOrderSummaryEatPlace.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrderSummaryEatPlace.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOrderSummaryEatPlace.Location = new System.Drawing.Point(19, 294);
            this.lblOrderSummaryEatPlace.Name = "lblOrderSummaryEatPlace";
            this.lblOrderSummaryEatPlace.Size = new System.Drawing.Size(192, 43);
            this.lblOrderSummaryEatPlace.TabIndex = 3;
            this.lblOrderSummaryEatPlace.Text = "Where To Eat:";
            // 
            // lblOrderSummaryCrust
            // 
            this.lblOrderSummaryCrust.AutoSize = true;
            this.lblOrderSummaryCrust.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrderSummaryCrust.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOrderSummaryCrust.Location = new System.Drawing.Point(17, 252);
            this.lblOrderSummaryCrust.Name = "lblOrderSummaryCrust";
            this.lblOrderSummaryCrust.Size = new System.Drawing.Size(91, 43);
            this.lblOrderSummaryCrust.TabIndex = 2;
            this.lblOrderSummaryCrust.Text = "Crust:";
            // 
            // lblOrderSummaryToppings
            // 
            this.lblOrderSummaryToppings.AutoSize = true;
            this.lblOrderSummaryToppings.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrderSummaryToppings.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOrderSummaryToppings.Location = new System.Drawing.Point(16, 146);
            this.lblOrderSummaryToppings.Name = "lblOrderSummaryToppings";
            this.lblOrderSummaryToppings.Size = new System.Drawing.Size(133, 43);
            this.lblOrderSummaryToppings.TabIndex = 1;
            this.lblOrderSummaryToppings.Text = "Toppings:";
            // 
            // lblOrderSummarySize
            // 
            this.lblOrderSummarySize.AutoSize = true;
            this.lblOrderSummarySize.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrderSummarySize.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOrderSummarySize.Location = new System.Drawing.Point(16, 99);
            this.lblOrderSummarySize.Name = "lblOrderSummarySize";
            this.lblOrderSummarySize.Size = new System.Drawing.Size(72, 43);
            this.lblOrderSummarySize.TabIndex = 0;
            this.lblOrderSummarySize.Text = "Size:";
            // 
            // gbPizzaOrderPlace
            // 
            this.gbPizzaOrderPlace.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaOrderPlace.Controls.Add(this.rbTakeOut);
            this.gbPizzaOrderPlace.Controls.Add(this.rbOnTable);
            this.gbPizzaOrderPlace.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbPizzaOrderPlace.ForeColor = System.Drawing.Color.Orange;
            this.gbPizzaOrderPlace.Location = new System.Drawing.Point(534, 361);
            this.gbPizzaOrderPlace.Name = "gbPizzaOrderPlace";
            this.gbPizzaOrderPlace.Size = new System.Drawing.Size(364, 167);
            this.gbPizzaOrderPlace.TabIndex = 3;
            this.gbPizzaOrderPlace.TabStop = false;
            this.gbPizzaOrderPlace.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbTakeOut.Location = new System.Drawing.Point(9, 94);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(154, 46);
            this.rbTakeOut.TabIndex = 4;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbOnTable
            // 
            this.rbOnTable.AutoSize = true;
            this.rbOnTable.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbOnTable.Location = new System.Drawing.Point(9, 49);
            this.rbOnTable.Name = "rbOnTable";
            this.rbOnTable.Size = new System.Drawing.Size(151, 46);
            this.rbOnTable.TabIndex = 3;
            this.rbOnTable.Text = "On Table";
            this.rbOnTable.UseVisualStyleBackColor = true;
            this.rbOnTable.CheckedChanged += new System.EventHandler(this.rbOnTable_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbToppings.ForeColor = System.Drawing.Color.Orange;
            this.gbToppings.Location = new System.Drawing.Point(534, 159);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(364, 196);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkPeppers.Location = new System.Drawing.Point(223, 129);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(139, 46);
            this.chkPeppers.TabIndex = 5;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkOlives.Location = new System.Drawing.Point(223, 90);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(112, 46);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkOnion.Location = new System.Drawing.Point(223, 49);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(116, 46);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkTomatoes.Location = new System.Drawing.Point(9, 129);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(160, 46);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkMushrooms.Location = new System.Drawing.Point(9, 90);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(182, 46);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.chkExtraCheese.Location = new System.Drawing.Point(6, 49);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(198, 46);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbMediumCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbCrustType.ForeColor = System.Drawing.Color.Orange;
            this.gbCrustType.Location = new System.Drawing.Point(235, 361);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(215, 167);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbThickCrust.Location = new System.Drawing.Point(18, 114);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(107, 46);
            this.rbThickCrust.TabIndex = 2;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbMediumCrust
            // 
            this.rbMediumCrust.AutoSize = true;
            this.rbMediumCrust.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbMediumCrust.Location = new System.Drawing.Point(18, 72);
            this.rbMediumCrust.Name = "rbMediumCrust";
            this.rbMediumCrust.Size = new System.Drawing.Size(141, 46);
            this.rbMediumCrust.TabIndex = 1;
            this.rbMediumCrust.TabStop = true;
            this.rbMediumCrust.Text = "Medium";
            this.rbMediumCrust.UseVisualStyleBackColor = true;
            this.rbMediumCrust.CheckedChanged += new System.EventHandler(this.rbMediumCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic);
            this.rbThinCrust.Location = new System.Drawing.Point(18, 34);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(97, 46);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // lblPizzaMake
            // 
            this.lblPizzaMake.AutoSize = true;
            this.lblPizzaMake.BackColor = System.Drawing.Color.Transparent;
            this.lblPizzaMake.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaMake.ForeColor = System.Drawing.Color.Orange;
            this.lblPizzaMake.Location = new System.Drawing.Point(383, 29);
            this.lblPizzaMake.Name = "lblPizzaMake";
            this.lblPizzaMake.Size = new System.Drawing.Size(545, 105);
            this.lblPizzaMake.TabIndex = 5;
            this.lblPizzaMake.Text = "Make Your Pizza";
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblOrder.Location = new System.Drawing.Point(279, 534);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(119, 53);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order";
            this.lblOrder.UseVisualStyleBackColor = true;
            this.lblOrder.Click += new System.EventHandler(this.lblOrder_Click);
            // 
            // btnRestForm
            // 
            this.btnRestForm.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRestForm.Location = new System.Drawing.Point(569, 534);
            this.btnRestForm.Name = "btnRestForm";
            this.btnRestForm.Size = new System.Drawing.Size(119, 53);
            this.btnRestForm.TabIndex = 7;
            this.btnRestForm.Text = "Rest";
            this.btnRestForm.UseVisualStyleBackColor = true;
            this.btnRestForm.Click += new System.EventHandler(this.btnRestForm_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject.Properties.Resources.download1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 611);
            this.Controls.Add(this.btnRestForm);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblPizzaMake);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbPizzaOrderPlace);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPizzaOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbPizzaOrderPlace.ResumeLayout(false);
            this.gbPizzaOrderPlace.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.GroupBox gbPizzaOrderPlace;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.Label lblPizzaMake;
        private System.Windows.Forms.Button lblOrder;
        private System.Windows.Forms.Button btnRestForm;
        private System.Windows.Forms.RadioButton rbLargeSize;
        private System.Windows.Forms.RadioButton rbMediumSize;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbMediumCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbOnTable;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Label lblOrderSummarySize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOrderSummaryEatPlace;
        private System.Windows.Forms.Label lblOrderSummaryCrust;
        private System.Windows.Forms.Label lblOrderSummaryToppings;
        private System.Windows.Forms.Label lblResultTotal;
        private System.Windows.Forms.Label lblResultEatPlace;
        private System.Windows.Forms.Label lblResultCrust;
        private System.Windows.Forms.Label lblResultSize;
        private System.Windows.Forms.TextBox lblResultToppings;
    }
}


//this.sizeRadioButtons.Add(rbSmallSize);
//this.sizeRadioButtons.Add(rbMediumSize);
//this.sizeRadioButtons.Add(rbLargeSize);
//this.crustRadioButtons.Add(rbThinCrust);
//this.sizeRadioButtons.Add(rbMediumCrust);
//this.sizeRadioButtons.Add(rbThickCrust);
//this.toppingsCheckBoxButtons.Add(chkExtraCheese);
//this.toppingsCheckBoxButtons.Add(chkMushrooms);
//this.toppingsCheckBoxButtons.Add(chkTomatoes);
//this.toppingsCheckBoxButtons.Add(chkOlives);
//this.toppingsCheckBoxButtons.Add(chkOnion);
//this.toppingsCheckBoxButtons.Add(chkPeppers);
//this.eatPlaceRadioButtons.Add(rbTakeOut);
//this.eatPlaceRadioButtons.Add(rbOnTable);
//this.groupBoxes.Add(gbPizzaSize);
//this.groupBoxes.Add(gbCrustType);
//this.groupBoxes.Add(gbToppings);
//this.groupBoxes.Add(gbPizzaOrderPlace);
//this.groupBoxes.Add(gbOrderSummary);