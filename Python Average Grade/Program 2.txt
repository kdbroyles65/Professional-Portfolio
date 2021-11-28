# -*- coding: utf-8 -*-
#CIS 443-75-4212
#Due Mar 9 @ 11:59PM
#Grading ID: P7113
#This program allows the user to specify a number of students and tests
#Then enter students names and test grades and will then display a bar
#chart with the averages for each letter grade represented by the data


import numpy as np
import seaborn as sns
def input_test_scores ():
    #collect data for number of students, number of tests and create test scores list
    num_of_students = int(input('How many students?: '))
    num_of_tests = int(input('How many tests for each student?: '))
    test_scores = []
    
    #add students
    for i in range (num_of_students):
        student_list = []
        student_list.append(input('Enter student name: '))
        
    #collect test score data and add it
        for k in range (num_of_tests):
            print('Enter test score for test',k+1,' : ')
            student_list.append(int(input()))
        test_scores.append(student_list)
    return test_scores

def summarize_test_scores(test_scores):
    #establish number of tests and create list to store means of scores 
    num_of_tests = len(test_scores[0])-1
    mean_of_scores = []

    #calculate the means and append them to the means list
    for score in test_scores:
        m = sum(score[1:])/num_of_tests
        mean_of_scores.append(m)
        
    #calculate and store letter grade data
    grades_list = []
    for i in mean_of_scores:
        if i>=90:
            grades_list.append('A')
        elif i>=80 and i<90:
            grades_list.append('B')
        elif i>=70 and i<80:
            grades_list.append('C')
        elif i>=60 and i<70:
            grades_list.append('D')
        elif i<60:
            grades_list.append('F')
            
    #Display Bar Chart
    title = 'Letter Grade Frequencies'
    sns.set_style('whitegrid')
    values, frequencies = np.unique(grades_list, return_counts=True)
    axes = sns.barplot(x= values, y=frequencies)
    axes.set_title(title)
    axes.set(xlabel='Letter Grades', ylabel ='Frequency')
    axes.set_ylim(top=max(frequencies)*1.10)
    for bar,frequency in zip(axes.patches, frequencies):
        text_x = bar.get_x() + bar.get_width()/2
        text_y = bar.get_height()
        text = f'{frequency}\n{frequency / len (grades_list):.3%}'
        axes.text(text_x, text_y, text, fontsize=11, ha='center',va='bottom')
        
score = input_test_scores()
summarize_test_scores(score)