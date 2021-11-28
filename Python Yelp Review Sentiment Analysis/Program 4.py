# -*- coding: utf-8 -*-
"""
Created on Wed Apr 21 13:12:56 2021
Course: 443-75-4212
Due: April 21 @11:59
Grading ID: P7113
Description: Takes a CSV of yelp reviews and breaks down the percentage of matches between star and text sentiment ratings of positive, 
neutral, and negative for each star rating

"""
import numpy as np
import pandas as pd
from textblob import TextBlob

def Reviews():
    data = pd.read_csv("yelp.csv")
    ratingData = pd.DataFrame(data)
    #print (ratingData)
    starSentiment = []
    for value in ratingData['stars']:
        if value >=4:
            starSentiment.append("positive")
        elif value == 3:
            starSentiment.append("neutral")
        else :
            starSentiment.append("negative")
    ratingData["star_sent"] = starSentiment
        
    #print(ratingData[['stars','star_sent']])

    textSentiment = []
    for value in ratingData['text']:
        analysisRaw = TextBlob(value).sentiment.polarity
        analysis = (analysisRaw)
        if analysis < -0.05:
            textSentiment.append('negative')
        elif analysis > 0.05:
            textSentiment.append('positive')
        else :
            textSentiment.append('neutral')
    ratingData["text_sent"] = textSentiment
    
    #print(ratingData[['star_sent','text_sent']])
    
    ratingData['sent_agreement'] = np.where(ratingData["star_sent"] == ratingData['text_sent'], 'True', 'False')
    
    #print(ratingData[['star_sent','text_sent','sent_agreement']])
    
    star = 5
    while star > 0:
        matches = 0
        star_sub = ratingData[ratingData.stars == star]
        for value in star_sub["sent_agreement"]:
            if value == 'True':
                matches += 1
        print ("For ", star," stars there are ", matches, "matches out of ", len(star_sub),"reviews, for a total of ",(matches/len(star_sub)*100), "%")
        star -= 1    
Reviews()