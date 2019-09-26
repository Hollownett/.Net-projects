using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Text;
using Android.Views;

using static Android.Views.View;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnClickListener
    {
        StringBuilder rezult = new StringBuilder();
        Button button7, button0, button1, button2, button3, button4, button5, button6, button8,
       button9, buttonSqrt, buttonSqr, buttonPow, buttonPow10, buttonSkobkaR, buttonSkobkaL,
       buttonDot, buttonPlus, buttonMinus, buttonMul, buttonDiv, buttonRezolv, buttonBksp,
       buttonCub, buttonC, buttonSin, buttonCos, buttonTan,buttonExp,buttonLog,buttonMod,buttonFact;
        private TextView textField, namberField;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
          
            textField = FindViewById<TextView>(Resource.Id.textField);
            namberField = FindViewById<TextView>(Resource.Id.numberField);
            button0 = FindViewById<Button>(Resource.Id.button0);
            button0.SetOnClickListener(this);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button1.SetOnClickListener(this);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button2.SetOnClickListener(this);
            button3 = FindViewById<Button>(Resource.Id.button3);
            button3.SetOnClickListener(this);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button4.SetOnClickListener(this);
            button5 = FindViewById<Button>(Resource.Id.button5);
            button5.SetOnClickListener(this);
            button6 = FindViewById<Button>(Resource.Id.button6);
            button6.SetOnClickListener(this);
            button7 = FindViewById<Button>(Resource.Id.button7);
            button7.SetOnClickListener(this);
            button8 = FindViewById<Button>(Resource.Id.button8);
            button8.SetOnClickListener(this);
            button9 = FindViewById<Button>(Resource.Id.button9);
            button9.SetOnClickListener(this);
            buttonSqrt = FindViewById<Button>(Resource.Id.buttonSqrt);
            buttonSqrt.SetOnClickListener(this);
            buttonSqr = FindViewById<Button>(Resource.Id.buttonSqr);
            buttonSqr.SetOnClickListener(this);
            buttonPow = FindViewById<Button>(Resource.Id.buttonPow);
            buttonPow.SetOnClickListener(this);
            buttonPow10 = FindViewById<Button>(Resource.Id.buttonPow10);
            buttonPow10.SetOnClickListener(this);
            buttonSkobkaR = FindViewById<Button>(Resource.Id.buttonSkobkaR);
            buttonSkobkaR.SetOnClickListener(this);
            buttonSkobkaL = FindViewById<Button>(Resource.Id.buttonSkobkaL);
            buttonSkobkaL.SetOnClickListener(this);
            buttonDot = FindViewById<Button>(Resource.Id.buttonDot);
            buttonDot.SetOnClickListener(this);
            buttonPlus = FindViewById<Button>(Resource.Id.buttonPlus);
            buttonPlus.SetOnClickListener(this);
            buttonMinus = FindViewById<Button>(Resource.Id.buttonMinus);
            buttonMinus.SetOnClickListener(this);
            buttonMul = FindViewById<Button>(Resource.Id.buttonMul);
            buttonMul.SetOnClickListener(this);
            buttonDiv = FindViewById<Button>(Resource.Id.buttonDiv);
            buttonDiv.SetOnClickListener(this);
            buttonRezolv = FindViewById<Button>(Resource.Id.buttonRezolv);
            buttonRezolv.SetOnClickListener(this);
            buttonBksp = FindViewById<Button>(Resource.Id.buttonBksp);
            buttonBksp.SetOnClickListener(this);
            buttonC = FindViewById<Button>(Resource.Id.buttonC);
            buttonC.SetOnClickListener(this);
            buttonSin = FindViewById<Button>(Resource.Id.buttonSin);
            buttonSin.SetOnClickListener(this);
            buttonCos = FindViewById<Button>(Resource.Id.buttonCos);
            buttonCos.SetOnClickListener(this);
            buttonTan = FindViewById<Button>(Resource.Id.buttonTan);
            buttonTan.SetOnClickListener(this);
            buttonCub = FindViewById<Button>(Resource.Id.buttonCub);
            buttonCub.SetOnClickListener(this);
            buttonMod = FindViewById<Button>(Resource.Id.buttonMod);
            buttonMod.SetOnClickListener(this);
            buttonExp = FindViewById<Button>(Resource.Id.buttonExp);
            buttonExp.SetOnClickListener(this);
            buttonLog = FindViewById<Button>(Resource.Id.buttonLog);
            buttonLog.SetOnClickListener(this);
            buttonFact = FindViewById<Button>(Resource.Id.buttonFact);
            buttonFact.SetOnClickListener(this);


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.button0:
                    {

                        rezult.Append("0");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button1: {

                        rezult.Append("1");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button2:
                    {

                        rezult.Append("2");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button3:
                    {

                        rezult.Append("3");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button4:
                    {

                        rezult.Append("4");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button5:
                    {

                        rezult.Append("5");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button6:
                    {

                        rezult.Append("6");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button7:
                    {

                        rezult.Append("7");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button8:
                    {

                        rezult.Append("8");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.button9:
                    {

                        rezult.Append("9");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonPlus:
                    {

                        rezult.Append("+");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonMinus:
                    {

                        rezult.Append("-");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonMul:
                    {

                        rezult.Append("*");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonDiv:
                    {

                        rezult.Append("/");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonPow:
                    {

                        rezult.Append("^");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonPow10:
                    {

                        rezult.Append("pow10(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonSqrt:
                    {

                        rezult.Append("sqrt(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonSqr:
                    {

                        rezult.Append("sqr(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonCub:
                    {

                        rezult.Append("cube(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonSin:
                    {

                        rezult.Append("sin(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonCos:
                    {

                        rezult.Append("cos(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonTan:
                    {

                        rezult.Append("tan(");
                        textField.Text = rezult.ToString();

                        break;

                    }
                case Resource.Id.buttonLog:
                    {

                        rezult.Append("log(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonMod:
                    {

                        rezult.Append("%");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonExp:
                    {

                        rezult.Append("Exp(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonFact:
                    {

                        rezult.Append("fact(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonSkobkaR:
                    {

                        rezult.Append(")");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonSkobkaL:
                    {

                        rezult.Append("(");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonDot:
                    {

                        rezult.Append(",");
                        textField.Text = rezult.ToString();

                        break;
                    }
                case Resource.Id.buttonBksp:
                    {
                        try
                        {
                            string len = rezult.ToString();
                            int lenght = len.Length - 1;
                            string text = rezult.ToString();
                            rezult.Clear();
                            for (int i = 0; i < lenght; i++)
                            {
                                rezult.Append(text[i]);
                            }
                            textField.Text = rezult.ToString();
                        }
                        catch (ArgumentOutOfRangeException e2)
                        {
                            Console.WriteLine(e2.Message);
                        }
                        

                        break;
                    }
                case Resource.Id.buttonC:
                    {
                       
                          rezult.Clear();
                          
                          textField.Text = rezult.ToString();
                   
                        break;
                    }
        




                case Resource.Id.buttonRezolv:
                    {
                        try
                        {
                            PostfixNotationExpression postfixNotationExpression = new PostfixNotationExpression();


                            textField.Text = postfixNotationExpression.result(rezult.ToString()).ToString();

                        }
                        catch (Exception ex)
                        {
                            textField.Text = "Error";
                        }
                        break;
                    }



            }
        }
    }
}