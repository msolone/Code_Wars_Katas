# Bocce Description
# Bocce is a game played by two competing teams, with three types of balls.
# Each team has its own set of balls (in this kata red and black) and there is a neutral ball called the jack.
# The jack is thrown at the beginning of each round, followed by the players trying to throw their balls as closely to it as possible.
#  The team with their balls closest to the jack wins the round!

# The number of points the winning team scores equals the number of their balls being closer to jack than any of the other
# team's balls: if the red team has 3 balls closer to jack than any of the black team's balls, they will win scoring 3 points.
# Equidistant balls on opposing teams will cancel out and neither team will score beyond that point.

# For more information on Bocce see here.

# Your task
# Implement a function that will return a message indicating the winner of the round.
# If there's no winner, return the string "No points scored".

# It takes an array of balls that are hash tables (depending on your language). Each ball has 2 properties: type and distance.

# The type will be "red", "black", or "jack". For all test cases, the jack will be the last element on the balls array.
#  The distance property will be an array with two integer values. The first value is the distance thrown forward,
#  the second value is the distance thrown left or right (negative values indicate distance to the left).
# For the purposes of this Kata, all balls are thrown from the same initial point.


def bocce_score(balls):
    # Determine Vertical and Horizontal distance of Jack
    JackVertical = balls[-1]['distance'][0]
    JackHorizontal = balls[-1]['distance'][1]

    # Eliminate the Jack from the balls list (the Jack is always last)
    balls = balls[:-1]
    for ball in balls:
        # use Right Triangles to determine the distance from Jack of each ball
        HorizontalLeg = abs(JackHorizontal - ball['distance'][1])
        VerticalLeg = abs(JackVertical - ball['distance'][0])
        Hypotenuse = ((HorizontalLeg ** 2) + (VerticalLeg ** 2)) ** (1/2)
        # Change the distance from 2 ints to a single int
        ball['distance'] = Hypotenuse

    # Create a list of only red balls
    reds = [x for x in balls if x['type'] == 'red']
    # Create a list of only black balls
    blacks = [x for x in balls if x['type'] == 'black']
    # Find minimum of the red balls list, to determine closest red ball to Jack
    minRed = min(reds, key=lambda x: x['distance'])['distance']
    # Find minimum of the back balls list, to determine closest black ball to Jack
    minBlack = min(blacks, key=lambda x: x['distance'])['distance']

    # If the min for both is the same then it is a tie
    if minRed == minBlack:
        return "No points scored"
    # If the minRed > minBlack then map a new list with only black balls that are less then the min red
    # The Length of that list will be the amount of points that black scores
    elif minRed > minBlack:
        return "black scores %d" % len([x for x in blacks if x['distance'] < minRed])
    # If the minBlack > minRed then map a new list with only red balls that are less then the min black
    # The Length of that list will be the amount of points that red scores
    else:
        return "red scores %d" % len([x for x in reds if x['distance'] < minBlack])
