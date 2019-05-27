# This program calculates the future value of an investment
# It takes in the present value, monthly interest, and duration
# Course: COMP 2211
# Date: May 26th, 2019
# Author: Michael MacKay
import math

def main():
    print('\nThis program will calculate your accounts future value base on its present value, interest rate and period?\n')
    present_value = float(eval(input('\tWhat is the present value in dollars: ')))
    interest_rate = float(eval(input('\tWhat is the interest rate as a percent: ')))
    monthly_period = float(eval(input('\tHow many months will it be invested: ')))

    # Assume if the interest rate is greater than 1 they input it as percent(whole numbers) rather than a float
    if interest_rate > 1:
        interest_rate /= 100

    calculate_future_value(present_value, interest_rate, monthly_period)

def calculate_future_value(present, interest, period):
    future_value = present * math.pow( (1.0 + interest), period)
    print('\nThe future value of your account will be: $%s' % format(future_value, '.2f'))

# Call Main
main()