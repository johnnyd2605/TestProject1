using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;


namespace TestProject
{
    internal class Program


    {

        private static ExtentReports _extent;
        private static ExtentTest _test;

        static void Main(string[] args)
        {
            string reportPath = @"C:\ruta\del\reporte.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);


            _test.Log(Status.Info, "Comenzando la prueba");
            _test.Log(Status.Pass, "La prueba ha sido exitosa");

            _extent.Flush();

            //Entrar al Sistema

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("TicTacToe.sln");
            driver.Manage().Window.Maximize();

            //Tomar captura de la pantalla

            driver.save_screenshot("captura1.png");

            // Acceder con las credenciales

            IWebElement btnlogin= driver.FindElement(By.Id("button1"));
            btnlogin.Click();

            // Comenzar el juego.

            IWebElement btnStart = driver.FindElement(By.Id("btnStart"));
            btnStart.Click();

            // Limpiar los datos ingresados del usuario.

            IWebElement btnClean = driver.FindElement(By.Id("btnClean"));
            btnClean.Click();

            // Reiniciar el juego.

            IWebElement btnRestart = driver.FindElement(By.Id("btnRestart"));
            btnRestart.Click();

            //Consultar los jugadores

            IWebElement btnSearch = driver.FindElement(By.Id("button1_Click"));
            btnSearch.Click();

            //Mostrar las fichas del juego.

            IWebElement btnSearch = driver.FindElement(By.Id("Buttons"));
            btnSearch.Click();

            // Escribir nombre de cada jugador 1

            cy.get('txtUser1').should('have.value');


            // Mostrar presencia del DataGrid View

            IWebElement dataGridView = driver.FindElement(By.Id("DataGridView1"));
            Assert.IsNotNull(dataGridView);

            // Verificar que el DataGridView tiene al menos una fila en sus campos.

            IWebElement firstCell = dataGridView.FindElement(By.XPath("//tr[1]/td[1]"));
            Assert.IsNotNull(firstCell);

            // Verificar que existe el label.

            WebElement label = driver.findElement(By.id("Label1"));
            Assertions.assertNotNull(label);

            // Verificar que el texto que tiene el label es correcto.

            String expectedText = "Tic Tac Toe!";
            String actualText = label.getText();
            Assertions.assertEquals(expectedText, actualText);

            // Acceder a las opciones del Combo Box

            IWebElement comboBox = driver.FindElement(By.Id("GroupBox1"));
            SelectElement select = new SelectElement(comboBox);
            select.SelectByText("Option 2");

            // Escribir nombre de cada jugador 2

            cy.get('txtUser2').should('have.value');

            // Mostrar DataGrid View

            IWebElement dataGridView = driver.FindElement(By.Id("DataGridView1"));
            Assert.IsNotNull(dataGridView);

            //Mostrar teclas.

            IWebElement btnSearch = driver.FindElement(By.Id("Buttons.Click"));
            btnSearch.Click();

            //Visualizar datos en DataGridView

            IWebElement btnSearch = driver.FindElement(By.Id("button1_Click"));
            btnSearch.Click();

            //Visualizar participantes anteriores.

            IWebElement btnSearch = driver.FindElement(By.Id("button3_Click"));
            btnSearch.Click();

            //Cierro la pagina web

            driver.Close();
        }

    }
}
