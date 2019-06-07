# This script validates codes by the following rules:
#   - At least 10 characters (some codes have more than 10 characters)
#   - Positions 4 through 7 must be digits (and represents the country in which the product will be sold)
#   - The character in the 10th position must be a capital letter and represents the security level of the product.
#   - Products with a security level of R (restricted) are no longer to be sold in countries with a country code of 2000 or higher
# Course: COMP 2211
# Date: June 6th, 2019
# Author: Michael MacKay

def main():
    invalid = []
    valid = []
    restricted = []

    file = open('A3 Codes.txt', 'r')

    # Read text line by line and apply to list once validated
    for line in range(10):
        t_line = file.readline()
        # Strip New Lines
        t_line = t_line.rstrip('\n')
        # Strip dashes (left out as I am not sure you wanted them counted as a char)
        # t_line = t_line.rstrip('-')
        val = validate(t_line)
        if val == 0:
            invalid.append(t_line)
        elif val == 1:
            valid.append(t_line)
        elif val == 2:
            restricted.append(t_line)
    
    file.close() # Stop memory leaks

    print('Invalid Code(s) are:')
    for code in invalid:
        print(code)
    
    print('\nValid Code(s) are:')
    for code in valid:
        print(code)

    print('\nRestricted Codes(s) are:')
    for code in restricted:
        print(code)

# Code Validation
# This method validates the code based on the parameters given in the assignment.
# Return values:    0 == INVALID
#                   1 == VALID
#                   2 == RESTRICTED
def validate(code):
    # Check Length
    if len(code) < 10:
        return 0
    # Check Country
    country_code = code[3:7]
    for char in country_code:
        if char.isdigit() != True:
            return 0
    # Check Security
    security_code = code[9]
    if security_code.isupper() != True:
        return 0
    # Code is Valid at this point
    # Check Restricted Check
    if security_code == 'R' and int(country_code) >= 2000:
        return 2
    # All Validation Passed
    return 1

main()