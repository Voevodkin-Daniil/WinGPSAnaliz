using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки для расчета входных параметров
        private void button1_Click(object sender, EventArgs e)
        {
            ClearResultFields();

            try
            {
                // Получаем координаты первого наблюдателя
                double observer1B = double.Parse(textBox_OO1_X.Text);
                double observer1L = double.Parse(textBox_OO1_Y.Text);
                double observer1Z = double.Parse(textBox_OO1_Z.Text);

                // Получаем координаты второго наблюдателя
                double observer2B = double.Parse(textBox_OO2_X.Text);
                double observer2L = double.Parse(textBox_OO2_Y.Text);
                double observer2Z = double.Parse(textBox_OO2_Z.Text);

                // Получаем координаты БПЛА
                double droneB = double.Parse(textBox_BPLA_X.Text);
                double droneL = double.Parse(textBox_BPLA_Y.Text);
                double droneHeight = double.Parse(textBox_BPLA_Z.Text);

                // Получаем координаты цели
                double targetB = double.Parse(textBox_T_X.Text);
                double targetL = double.Parse(textBox_T_Y.Text);
                double targetZ = double.Parse(textBox_T_Z.Text);

                // Сохраняем координаты наблюдателей для дальнейших расчетов
                textBox_Input_OO1_X.Text = textBox_OO1_X.Text;
                textBox_Input_OO1_Y.Text = textBox_OO1_Y.Text;
                textBox_Input_OO2_X.Text = textBox_OO2_X.Text;
                textBox_Input_OO2_Y.Text = textBox_OO2_Y.Text;

                textBoxBPLA_TEST_H.Text = droneHeight.ToString();

                // Проецирование всех данных на плоскость гауса
                double[] temp = TranslationWGS84.ConvertToGaussKrueger(observer1B * Math.PI / 180, observer1L * Math.PI / 180);
                double observer1X = temp[0], observer1Y = temp[1];

                temp = TranslationWGS84.ConvertToGaussKrueger(observer2B * Math.PI / 180, observer2L * Math.PI / 180);
                double observer2X = temp[0], observer2Y = temp[1];

                temp = TranslationWGS84.ConvertToGaussKrueger(droneB * Math.PI / 180, droneL * Math.PI / 180);
                double droneX = temp[0], droneY = temp[1];

                temp = TranslationWGS84.ConvertToGaussKrueger(targetB * Math.PI / 180, targetL * Math.PI / 180);
                double targetX = temp[0], targetY = temp[1];

                // Рассчитываем расстояние от первого наблюдателя до БПЛА (L1)



                textBox_Input_L1.Text = Math.Sqrt(
                    Math.Pow(droneHeight - observer1Z, 2) +
                    Math.Pow(droneX - observer1X, 2) +
                    Math.Pow(droneY - observer1Y, 2)).ToString();

                // Рассчитываем расстояние от второго наблюдателя до БПЛА (L2)
                textBox_Input_L2.Text = Math.Sqrt(
                    Math.Pow(droneHeight - observer2Z, 2) +
                    Math.Pow(droneX - observer2X, 2) +
                    Math.Pow(droneY - observer2Y, 2)).ToString();

                // Рассчитываем расстояние от БПЛА до цели (L3)
                textBox_Input_L3.Text = Math.Sqrt(
                    Math.Pow(droneHeight - targetZ, 2) +
                    Math.Pow(droneX - targetX, 2) +
                    Math.Pow(droneY - targetY, 2)).ToString();

                // Вычисляем угол между БПЛА, первым наблюдателем и целью (угол a)
                double sideA = Math.Sqrt(Math.Pow(observer1X - targetX, 2) + Math.Pow(observer1Y - targetY, 2));
                double sideB = Math.Sqrt(Math.Pow(droneX - targetX, 2) + Math.Pow(droneY - targetY, 2));
                double sideC = Math.Sqrt(Math.Pow(droneX - observer1X, 2) + Math.Pow(droneY - observer1Y, 2));

                MessageBox.Show($"{sideA}",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                double angleA = Math.Sign(-((observer1X - droneX) * (targetY - droneY) - (observer1Y - droneY) * (targetX - droneX))) *
                    Math.Acos((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC))
                    * 180 / Math.PI;

                textBox_Input_a.Text = angleA.ToString();

                // Вычисляем угол между БПЛА, вторым наблюдателем и целью (угол b)
                sideA = Math.Sqrt(Math.Pow(observer2X - targetX, 2) + Math.Pow(observer2Y - targetY, 2));
                sideB = Math.Sqrt(Math.Pow(droneX - targetX, 2) + Math.Pow(droneY - targetY, 2));
                sideC = Math.Sqrt(Math.Pow(droneX - observer2X, 2) + Math.Pow(droneY - observer2Y, 2));

                double angleB = Math.Sign(-((observer2X - droneX) * (targetY - droneY) - (observer2Y - droneY) * (targetX - droneX))) *
                    Math.Acos((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC))
                    * 180 / Math.PI;

                MessageBox.Show($"{sideA}",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox_Input_b.Text = angleB.ToString();


                // Вычисляем углы позиции
                // (угол aa)
                sideA = observer1Z - droneHeight;
                sideB = Math.Sqrt(Math.Pow(droneX - observer1X, 2) + Math.Pow(droneY - observer1Y, 2));
                sideC = Math.Sqrt(Math.Pow(droneX - observer1X, 2) + Math.Pow(droneY - observer1Y, 2) + Math.Pow(droneHeight - observer1Z, 2));
                double angleAA = Math.Sign(sideA) * Math.Acos((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC)) * 180 / Math.PI;
                textBox_Input_aa.Text = angleAA.ToString();

                // (угол bb)
                sideA = observer2Z - droneHeight;
                sideB = Math.Sqrt(Math.Pow(droneX - observer2X, 2) + Math.Pow(droneY - observer2Y, 2));
                sideC = Math.Sqrt(Math.Pow(droneX - observer2X, 2) + Math.Pow(droneY - observer2Y, 2) + Math.Pow(droneHeight - observer2Z, 2));
                double angleBB = Math.Sign(sideA) * Math.Acos((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC)) * 180 / Math.PI;
                textBox_Input_bb.Text = angleBB.ToString();


                // (угол c)
                sideA = targetZ - droneHeight;
                sideB = Math.Sqrt(Math.Pow(droneX - targetX, 2) + Math.Pow(droneY - targetY, 2));
                sideC = Math.Sqrt(Math.Pow(droneX - targetX, 2) + Math.Pow(droneY - targetY, 2) + Math.Pow(droneHeight - targetZ, 2));
                double angleC = Math.Sign(sideA) * Math.Acos((sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC)) * 180 / Math.PI;
                textBox_Input_сc.Text = angleC.ToString();


                // Устанавливаем погрешности по умолчанию (0)
                textBox_dL1.Text = "0";
                textBox_dL2.Text = "0";
                textBox_dL3.Text = "0";
                textBox_dс.Text = "0";
                textBox_da.Text = "0";
                textBox_daa.Text = "0";
                textBox_db.Text = "0";
                textBox_dbb.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка может быть связана с некорректной задачей координат. Разделитель вещественной части ,",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки для расчета координат цели
        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем поля с результатами
            ClearResultFields();

            try
            {
                // Получаем входные параметры
                double observer1B = double.Parse(textBox_Input_OO1_X.Text);
                double observer1L = double.Parse(textBox_Input_OO1_Y.Text);
                double observer2B = double.Parse(textBox_Input_OO2_X.Text);
                double observer2L = double.Parse(textBox_Input_OO2_Y.Text);

                double BPLA_H = double.Parse(textBoxBPLA_TEST_H.Text);

                double distanceToDroneFromObs1 = double.Parse(textBox_Input_L1.Text);
                double distanceToDroneFromObs2 = double.Parse(textBox_Input_L2.Text);
                double distanceToTargetFromDrone = double.Parse(textBox_Input_L3.Text);
                double angleCC = double.Parse(textBox_Input_сc.Text);

                double angleA = double.Parse(textBox_Input_a.Text);
                double angleAA = double.Parse(textBox_Input_aa.Text);
                double angleB = double.Parse(textBox_Input_b.Text);
                double angleBB = double.Parse(textBox_Input_bb.Text);

                double observer1Z = BPLA_H + distanceToDroneFromObs1 * Math.Sin(Math.PI * angleAA / 180);
                double observer2Z = BPLA_H + distanceToDroneFromObs2 * Math.Sin(Math.PI * angleBB / 180);

                // Проецирование всех данных на плоскость гауса
                double[] temp = TranslationWGS84.ConvertToGaussKrueger(observer1B / 180 * Math.PI, observer1L / 180 * Math.PI);
                double observer1X = temp[0], observer1Y = temp[1];

                temp = TranslationWGS84.ConvertToGaussKrueger(observer2B / 180 * Math.PI, observer2L / 180 * Math.PI);
                double observer2X = temp[0], observer2Y = temp[1];

                // Получаем координаты БПЛА и цели
                double[][] result = TargetLocator.GetTargetCoordinates(
                    observer1X, observer1Y, observer1Z, observer2X, observer2Y, observer2Z,
                    distanceToDroneFromObs1, distanceToDroneFromObs2, distanceToTargetFromDrone,
                    angleA, angleB, angleAA, angleBB, angleCC);

                // Выводим результаты для БПЛА
                double[] BPLA_WGS84 = TranslationWGS84.ConvertFromGaussKrueger(result[0][0], result[0][1]);
                textBox_Rez_BPLA_X.Text = (BPLA_WGS84[0] * 180 / Math.PI).ToString();
                textBox_Rez_BPLA_Y.Text = (BPLA_WGS84[1] * 180 / Math.PI).ToString();
                textBox_Rez_BPLA_Z.Text = Math.Round(result[0][2], 5).ToString() + " М";
                //textBox_Rez_BPLA_Z.Text = "";

                // Выводим результаты для цели
                double[] T_WGS84 = TranslationWGS84.ConvertFromGaussKrueger(result[1][0], result[1][1]);
                textBox_Rez_T_X.Text = (T_WGS84[0] * 180 / Math.PI).ToString();
                textBox_Rez_T_Y.Text = (T_WGS84[1] * 180 / Math.PI).ToString();
                textBox_Rez_T_Z.Text = Math.Round(result[1][2], 5).ToString() + " М";
                //textBox_Rez_T_Z.Text = "";


                // Альтернативный расчет координат цели (векторный метод)
                /*
                double[][] alternativeResult = TargetLocator.GetTargetCoordinatesAlternative(
                    observer1X, observer1Y, observer1Z, observer2X, observer2Y, observer2Z,
                    distanceToDroneFromObs1, distanceToDroneFromObs2, distanceToTargetFromDrone,
                    angleA, angleB, angleAA, angleBB, angleC);

                textBox_v1_x.Text = Math.Round(alternativeResult[1][0], 5).ToString() + " X";
                textBox_v1_y.Text = Math.Round(alternativeResult[1][1], 5).ToString() + " Y";
                textBox_v1_z.Text = Math.Round(alternativeResult[1][2], 5).ToString() + " Z";
                */

                /*
                // Расчет с учетом погрешностей
                double errorL1 = double.Parse(textBox_dL1.Text);
                double errorL2 = double.Parse(textBox_dL2.Text);
                double errorL3 = double.Parse(textBox_dL3.Text);
                double errorAngleC = double.Parse(textBox_dс.Text);
                double errorAngleA = double.Parse(textBox_da.Text);
                double errorAngleB = double.Parse(textBox_db.Text);
                double errorAngleAA = double.Parse(textBox_daa.Text);
                double errorAngleBB = double.Parse(textBox_dbb.Text);
                try
                {
                    double[][] resultWithError = TargetLocator.GetTargetCoordinates(
                                                observer1X, observer1Y, observer1Z,
                                                observer2X, observer2Y, observer2Z,
                                                distanceToDroneFromObs1 + errorL1,
                                                distanceToDroneFromObs2 + errorL2,
                                                distanceToTargetFromDrone + errorL3,
                                                angleA + errorAngleA, angleB + errorAngleB,
                                                angleAA + errorAngleAA, angleBB + errorAngleBB,
                                                angleC + errorAngleC);


                    // Выводим результаты с учетом погрешностей
                    textBox_Rez_D_BPLA_X.Text = Math.Round(resultWithError[0][0], 5).ToString() + " X";
                    textBox_Rez_D_BPLA_Y.Text = Math.Round(resultWithError[0][1], 5).ToString() + " Y";
                    textBox_Rez_D_BPLA_Z.Text = Math.Round(resultWithError[0][2], 5).ToString() + " Z";
                    textBox_Rez_D_T_X.Text = Math.Round(resultWithError[1][0], 5).ToString() + " X";
                    textBox_Rez_D_T_Y.Text = Math.Round(resultWithError[1][1], 5).ToString() + " Y";
                    textBox_Rez_D_T_Z.Text = Math.Round(resultWithError[1][2], 5).ToString() + " Z";

                    // Рассчитываем отклонения из-за погрешностей
                    textBox_Rez_BPLA.Text = Math.Sqrt(
                        Math.Pow(result[0][0] - resultWithError[0][0], 2) +
                        Math.Pow(result[0][1] - resultWithError[0][1], 2)).ToString();

                    textBox_Rez_T.Text = Math.Sqrt(
                        Math.Pow(result[1][0] - resultWithError[1][0], 2) +
                        Math.Pow(result[1][1] - resultWithError[1][1], 2) +
                        Math.Pow(result[1][2] - resultWithError[1][2], 2)).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обработке значений с погрешностью в 1 случае",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */

                
               
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для очистки полей с результатами
        private void ClearResultFields()
        {
            textBox_Rez_BPLA_X.Text = "";
            textBox_Rez_BPLA_Y.Text = "";
            textBox_Rez_BPLA_Z.Text = "";
            textBox_Rez_D_BPLA_X.Text = "";
            textBox_Rez_D_BPLA_Y.Text = "";
            textBox_Rez_D_BPLA_Z.Text = "";
            textBox_Rez_BPLA.Text = "";

            textBox_Rez_T_X.Text = "";
            textBox_Rez_T_Y.Text = "";
            textBox_Rez_T_Z.Text = "";
            textBox_Rez_D_T_X.Text = "";
            textBox_Rez_D_T_Y.Text = "";
            textBox_Rez_D_T_Z.Text = "";
            textBox_Rez_T.Text = "";

            /*
            textBox_v1_x.Text = "";
            textBox_v1_y.Text = "";
            textBox_v1_z.Text = "";
            textBox_v2_x.Text = "";
            textBox_v2_y.Text = "";
            textBox_v2_z.Text = "";
            textBox_vvv.Text = "";
            */
        }


        private void textBox_OO1_Y_TextChanged(object sender, EventArgs e) { }
        private void label34_Click(object sender, EventArgs e) { }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∠C — угол места для Цели.\n" +
                "Это угловая высота объекта над горизонтом.\n" +
                "Результат измеряется в градусах.",
                "Параметр ∠C",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Пожалуйста, введите координаты Опорного Объекта 1.\n" +
                "Три поля соответствуют координатам X, Y и Z соответственно.",
                "Сообщение: Опорный Объект 1",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Пожалуйста, введите координаты Опорного Объекта 2.\n" +
                "Три поля соответствуют координатам X, Y и Z соответственно.",
                "Сообщение: Опорный Объект 2",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Пожалуйста, введите координаты БПЛА.\n" +
                "Три поля соответствуют координатам X, Y и Z соответственно.",
                "Сообщение: БПЛА",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Пожалуйста, введите координаты Цели.\n" +
                "Три поля соответствуют координатам X, Y и Z соответственно.",
                "Сообщение: Цель",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Координаты Опорного Объекта 1.\n" +
                "Два поля - долгота и широта в радианах.",
                "Опорный Объект 1",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Координаты Опорного Объекта 2.\n" +
                "Два поля - долгота и широта в радианах.",
                "Опорный Объект 2",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "L1 — расстояние между Опорным Объектом 1 (ОО1) и БПЛА.\n" +
                "Параметр измеряется дальномером.",
                "Параметр L1",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "L2 — расстояние между Опорным Объектом 2 (ОО2) и БПЛА.\n" +
                "Параметр измеряется дальномером.",
                "Параметр L2",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "L3 — расстояние между Целью и БПЛА.\n" +
                "Параметр измеряется дальномером.",
                "Параметр L3",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∠a — угол (азимут) между Целью, БПЛА и Опорным Объектом 1 (ОО1).\n" +
                "Результат измеряется в градусах.\n" +
                "Параметр измеряется угломером.",
                "Параметр ∠a - Азимут",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∠b — угол (азимут) между Целью, БПЛА и Опорным Объектом 2 (ОО2).\n" +
                "Результат измеряется в градусах.\n" +
                "Параметр измеряется угломером.",
                "Параметр ∠b - Азимут",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∠A — угол места для Опорного Объекта 1 (ОО1).\n" +
                "Это угловая высота объекта над горизонтом.\n" +
                "Результат измеряется в градусах.",
                "Параметр ∠A",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∠B — угол места для Опорного Объекта 2 (ОО2).\n" +
                "Это угловая высота объекта над горизонтом.\n" +
                "Результат измеряется в градусах.",
                "Параметр ∠B",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆L1 — абсолютная погрешность параметра L1, выраженная в метрах.\n" +
                "Погрешность измерения — это отклонение измеренного значения от истинного значения величины L1.\n",
                "Параметр ∆L1",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆L2 — абсолютная погрешность параметра L2, выраженная в метрах.\n" +
                "Погрешность измерения — это отклонение измеренного значения от истинного значения величины L2.\n",
                "Параметр ∆L2",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆L3 — абсолютная погрешность параметра L3, выраженная в метрах.\n" +
                "Погрешность измерения — это отклонение измеренного значения от истинного значения величины L3.\n",
                "Параметр ∆L3",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆∠a — абсолютная погрешность параметра ∠a, выраженная в градусах.\n" +
                "Абсолютная погрешность показывает максимально возможное отклонение измеренного значения угла ∠a от его истинного значения.",
                "Параметр ∆∠a",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

        }

        private void label35_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆∠b — абсолютная погрешность параметра ∠b, выраженная в градусах.\n" +
                "Абсолютная погрешность показывает максимально возможное отклонение измеренного значения угла ∠b от его истинного значения.",
                "Параметр ∆∠b",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆∠A — абсолютная погрешность параметра ∠A, выраженная в градусах.\n" +
                "Абсолютная погрешность показывает максимально возможное отклонение измеренного значения угла ∠A от его истинного значения.",
                "Параметр ∆∠A",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆∠B — абсолютная погрешность параметра ∠B, выраженная в градусах.\n" +
                "Абсолютная погрешность показывает максимально возможное отклонение измеренного значения угла ∠B от его истинного значения.",
                "Параметр ∆∠B",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "∆∠C — абсолютная погрешность параметра ∠C, выраженная в градусах.\n" +
                "Абсолютная погрешность показывает максимально возможное отклонение измеренного значения угла ∠C от его истинного значения.",
                "Параметр ∆∠C",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}