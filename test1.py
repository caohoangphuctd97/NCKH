import sys
from PyQt5.QtGui import *
from PyQt5.QtCore import *
from PyQt5.QtWidgets import QApplication,QDialog
from PyQt5.uic import loadUi
import thuattoan as tt
import random
class genetic_algorithm(QDialog):

    def __init__(self):
        super(genetic_algorithm, self).__init__()
        loadUi('genetic_algorithm.ui', self)

        self.flag = False

        #####  Parameter     #######
        self.spinBox_4.valueChanged.connect(self.valuechange)
        self.spinBox_4.setMaximum(10000)
        self.spinBox_4.setMinimum(0)
        self.spinBox_5.valueChanged.connect(self.valuechange)
        self.spinBox_5.setMaximum(10000)
        self.spinBox_5.setMinimum(0)
        self.doubleSpinBox_2.valueChanged.connect(self.valuechange)
        self.doubleSpinBox_2.setMaximum(100.00)
        self.doubleSpinBox_2.setMinimum(0)

        self.doubleSpinBox_3.valueChanged.connect(self.valuechange)
        self.doubleSpinBox_3.setMaximum(100.00)
        self.doubleSpinBox_3.setMinimum(0)

        ##### RUN ####################
        self.pushButton_4.clicked.connect(self.RUN)

        ##### CREATE TABLE ###########
        self.spinBox.valueChanged.connect(self.parameter_table)
        self.spinBox_2.valueChanged.connect(self.parameter_table)
        self.spinBox_3.valueChanged.connect(self.parameter_table)
        self.pushButton.clicked.connect(self.create_table)
        self.pushButton_2.clicked.connect(self.get_value)

    def parameter_table(self):
        self.num_of_jobs = self.spinBox.value()
        self.num_of_process = self.spinBox_2.value()
        self.num_of_machines = self.spinBox_3.value()


    def create_table(self):
        self.tableWidget.setRowCount(self.num_of_process+1)
        self.tableWidget.setColumnCount(self.num_of_jobs)
        horHeaders = []
        verHeaders = []
        verHeaders.append('Process')
        for n in range(self.num_of_jobs):
            horHeaders.append('JOB %d' % (n + 1))
        for n in range(1,self.num_of_process+1):
            verHeaders.append('%d' %n)
        print(horHeaders)
        print(verHeaders)
        self.tableWidget.setHorizontalHeaderLabels(horHeaders)
        self.tableWidget.setVerticalHeaderLabels(verHeaders)
        weight = 150 * self.num_of_jobs
        if weight > 1067:
            weight = 1067
        height = 60 * self.num_of_process
        if height > 280:
            height = 280
        self.tableWidget.setGeometry(30, 250, weight, height)

    def get_value(self):
        self.job = []
        for i in range(1, self.num_of_process+1):
            process = []
            for j in range(self.num_of_jobs):
                process.append(int(self.tableWidget.item(i,j).text()))
            self.job.append(process)
        print(type(self.job[0][0]))

    def valuechange(self):
        self.pop_size = self.spinBox_4.value()
        self.loop_time = self.spinBox_5.value()
        self.mutate = self.doubleSpinBox_2.value()
        self.crossover = self.doubleSpinBox_3.value()

    def RUN(self):
        tt.job = self.job
        tt.num_of_jobs = self.num_of_jobs
        tt.num_of_machines = self.num_of_machines
        tt.num_of_process = self.num_of_process
        tt.pop_size = self.pop_size
        tt.mutate = self.mutate
        tt.crossover = self.crossover
        tt.Loop = self.loop_time
        self.makespan, self.jobs_time, self.num_jobs = tt.chuongtrinh()
        print(self.makespan)
        self.flag = True
        self.update()

    def paintEvent(self, event):
        if self.flag == True:
            self.flag == False
            qp = QPainter()
            qp.begin(self)
            ########## DRAW JOB, POINT ##############
            x = 65
            y = 560
            color = []
            for i in range(tt.num_of_jobs):
                red = random.randint(0, 255)
                blue = random.randint(0, 255)
                green = random.randint(0, 255)
                color.append([red, blue, green])
                qp.setPen(QColor(red, blue, green))
                qp.setBrush(QColor(red, blue, green))
                qp.drawEllipse(x + i*50, y, 10, 10)

                qp.setPen(QColor(Qt.black))
                qp.setFont(QFont('Arial', 10))
                qp.drawText(x+15 + i*50, y+12, "M%d" %(i+1))

                qp.drawText(40, 625 + i*30, "M%d" % (i + 1))
            i = 0
            while(50*i < self.makespan+50):
                qp.drawLine(70+50*i, 600, 70+50*i, 595+(tt.num_of_jobs)*30)
                qp.drawText(60+50*i, 595, "%d" %(i*50))
                i += 1
            end = i
            weight = 150 + int(self.makespan/50)*50
            if weight < 200:
                weight = 230 + tt.num_of_jobs*30
            height = 80 + tt.num_of_jobs*30
            qp.setBrush(Qt.NoBrush)
            qp.drawRect(30, 540, weight, height)

            ####### DRAW LINES ########################################
            for a in range(tt.num_of_jobs):
                qp.setBrush(QColor(217, 217, 217))
                qp.drawRect(70, 610 + a*30, 50*(i-1), 20)

            ############## Write ##################################3##
            makespan = []
            for n,job in enumerate(self.jobs_time):
                start = 70
                for i, time in enumerate(job):
                    if self.num_jobs[n][i] != 'a':
                        job_color = self.num_jobs[n][i][0]
                        qp.setBrush(QColor(color[job_color-1][0],color[job_color-1][1],color[job_color-1][2]))
                        qp.drawRect(start, 610 + n * 30, time, 20)
                        if time > 50:
                            qp.drawText(start+5, 627 + n * 30, '%(a)d-%(b)d'%{'a':self.num_jobs[n][i][0], "b":self.num_jobs[n][i][1]})
                        elif time > 20:
                            qp.drawText(start+5, 627 + n * 30,'%d' %self.num_jobs[n][i][1])

                    start += time
                makespan.append(start-70)
            for a in range(tt.num_of_machines):
                qp.drawText(75 + 50 * (end - 1), 627 + a*30, '%d' %makespan[a] )
            qp.end()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    widget = genetic_algorithm()
    widget.show()
    sys.exit(app.exec_())
