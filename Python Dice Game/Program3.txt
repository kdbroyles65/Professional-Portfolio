# -*- coding: utf-8 -*-
"""
Created on Sun Mar 28 17:35:57 2021

@author: KyleB
"""

import random

def roll_dice():
    """Roll two dice and return their face values as a tuple."""
    die1 = random.randrange(1, 7)
    die2 = random.randrange(1, 7)
    return (die1, die2)  # pack die face values into a tuple

def display_dice(dice):
    """Display one roll of the two dice."""
    die1, die2 = dice  # unpack the tuple into variables die1 and die2
    
    
def one_game ():
    die_values = roll_dice()  # first roll
    display_dice(die_values)
    attempts = 0
    # determine game status and point, based on first roll
    sum_of_dice = sum(die_values)

    if sum_of_dice in (7, 11):  # win
        game_status = 'WON'
    elif sum_of_dice in (2, 3, 12):  # lose
        game_status = 'LOST'
    else:  # remember point
        attempts = 1
        game_status = 'CONTINUE'
        my_point = sum_of_dice
        

    # continue rolling until player wins or loses
    while game_status == 'CONTINUE':
        attempts += 1
        die_values = roll_dice()
        display_dice(die_values)
        sum_of_dice = sum(die_values)

        if sum_of_dice == my_point:  # win by making point
            game_status = 'WON'
        elif sum_of_dice == 7:  # lose by rolling 7
            game_status = 'LOST'

    # display "wins" or "loses" message
    if game_status == 'WON':
        return 'WON',attempts
    else:
        return 'LOSS',attempts
        
def m_games ():
    rolls = [0]*25  #initiate rolls
    total_games = 1000000 #set number of games to play
    wins = 0 #initiate wins
    losses = 0 #initiate losses
    
    #document number of games played and the attempts at those points
    for game in range(total_games):
        winloss,attempts = one_game()
        if winloss=='WON':
            wins += 1
        else:
            losses += 1
        if attempts <=len(rolls):
            rolls[attempts-1]+=1
        else:
            rolls[-1]+=1
        
    #display output headers and totals info per the picture provided
    print('Percentage of wins: {:.2f}%'.format(wins*100/(total_games)))
    print('Percentage of losses: {:.2f}%'.format(losses*100/(total_games)))
    print('Percentage of wins/losses based on total number of rolls')
    print()
    print('{:>20}{:>15} '.format('% Resolved','Cummulative %'))
    print('{:<1}{:>15} {:>15}'.format('Rolls','on this roll','of games resolved'))
    
    #display the attempts and rolls with totals for 1-25 rolls
    for i in range (len(rolls)):
        Res = rolls[i]*100/total_games
        Cum_res = 100*sum(rolls[0:i])/total_games
        if i!= len(rolls)-1:
            print('{:>1}{:>15.2f}%{:>15.2f}%'.format(i+1,Res,Cum_res))
        else:
            print('{:>1}{:>15.2f}%{:>15.2f}%'.format(i + 1, Res, 100*sum(rolls)/total_games))
        

m_games()