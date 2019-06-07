# This program generates a user name based on their first name, last name,
# and id - then it asks the user to create a password that is verified to 
# be at least 7 chars in length, with at least one uppercase, lowercase, 
# and digit included.
# Course: COMP 2211
# Date: June 1st, 2019
# Author: Michael MacKay

def main():
    # Generate Login
    firstName = input('\tWhat is your first name: ')
    lastName = input('\tWhat is your last name: ')
    student_id = input('\tWhat is your id: ')

    login_name = get_login_name(firstName, lastName, student_id)
    print('\t\tYour new username is: ' + login_name)

    # Password verification loop
    is_verified = False
    while is_verified == False:
        is_verified = verify_password(input('\tPlease enter your password: '))
        
        if is_verified:
            print('\t\tYour password has been accepted.')
        else:
            print('\t\tThe password you entered is not valid, please try again.')



def get_login_name(firstName, lastName, student_id):
    # First Name
    if len(firstName) >= 2:
        t_firstName = firstName[0:3]
    else:
        t_firstName = firstName

    # Last Name
    if len(lastName) >= 2:
        t_lastName = lastName[0:3]
    else:
        t_lastName = lastName

    # ID
    t_id = student_id[-3:]

    return(str(t_firstName + t_lastName + str(t_id)))

def verify_password(user_password):
    has_lower = False
    has_upper = False
    has_digit = False
    is_verified = False

    # Make sure the length is 7 or more
    if len(user_password) >= 7:
        # Loop through the chars in the password
        for char in user_password:

            if char.islower():
                has_lower = True
            
            if char.isupper():
                has_upper = True
            
            if char.isdigit():
                has_digit = True
        
        # If all qualifiers are met then the password is verified
        if has_lower and has_upper and has_digit:
            is_verified = True

    return(is_verified)


# Call Main
main()

    
