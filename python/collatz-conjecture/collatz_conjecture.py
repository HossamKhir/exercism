def steps(number):
    if number <= 0:
        raise ValueError("Only positive integers are allowed")
    count = 0
    while number != 1:
        if not number % 2:
            number //= 2
        else:
            number = (3 * number) + 1
        count += 1
    return count
