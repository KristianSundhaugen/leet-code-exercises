# If we have two people with different calendars and want to find atleast 30 minutes or more open time for them to have meetings throughout a workday
# Calendar person 1: [['9:00', '10:30'], ['12:00', '13:00'],['16:00', '18:00']]
# And within person 1 workady bounds ['9:00', '20:00']
# Calendar person 2: [['10:00', '11:30'], ['12:30', '14:30'],['14:30', '15:00'],['16:00', '17:00']]
# And within person 2 bounds ['10:00', '18:30']
# Sample output:  [['11:30', '12:00'], ['15:00', '16:00'],['18:00', '18:30']]
# Gotten from: https://www.youtube.com/watch?v=3Q_oYDQ2whs&ab_channel=Cl%C3%A9mentMihailescu

def findAvailableMeetingSlots(person1Calendar, person1Bounds, person2Calendar, person2Bounds):
    mergedSlots = mergeTimeSlots(person1Calendar, person2Calendar)
    mergedSlots.sort(key=lambda slot: slot[0])

    availableSlots = []

    prevEndTime = person1Bounds[0]

    for slot in mergedSlots:
        startTime, endTime = slot

        if prevEndTime < startTime:
            gap = [prevEndTime, startTime]
            if calculateMinutes(gap) >= 30:
                availableSlots.append(gap)

        prevEndTime = max(prevEndTime, endTime)

    if prevEndTime < person2Bounds[1]:
        gap = [prevEndTime, person2Bounds[1]]
        if calculateMinutes(gap) >= 30:
            availableSlots.append(gap)

    return availableSlots


def mergeTimeSlots(*calendars):
    mergedSlots = []
    for calendar in calendars:
        mergedSlots.extend(calendar)
    return mergedSlots


def calculateMinutes(slot):
    startTime = slot[0]
    endTime = slot[1]
    startHour, startMin = map(int, startTime.split(':'))
    endHour, endMin = map(int, endTime.split(':'))
    return (endHour - startHour) * 60 + (endMin - startMin)


# Example usage
person1Calendar = [['09:00', '10:30'], ['12:00', '13:00'], ['16:00', '18:00']]
person1Bounds = ['09:00', '20:00']

person2Calendar = [['10:00', '11:30'], ['12:30', '14:30'], ['14:30', '15:00'], ['16:00', '17:00']]
person2Bounds = ['10:00', '18:30']

result = findAvailableMeetingSlots(person1Calendar, person1Bounds, person2Calendar, person2Bounds)
print(result)  # Output: [['11:30', '12:00'], ['15:00', '16:00'], ['18:00', '18:30']]
