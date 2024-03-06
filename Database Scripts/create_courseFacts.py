import csv
import random

# Define the ranges
range1 = range(0, 293)
range2 = range(0, 1000)
range3 = range(0, 100001)
range4 = range(0, 100000)
range5 = [1]

# Number of rows in the CSV
num_rows = 500000  # You can adjust this based on your needs

# Generate random values and write to CSV
with open('courseFact (3).csv', 'w', newline='') as csvfile:
    csv_writer = csv.writer(csvfile)

    # Write header if needed
    csv_writer.writerow(['Column1', 'Column2', 'Column3', 'Column4', 'Column5'])

    for _ in range(num_rows):
        row_data = [
            random.choice(range1),
            random.choice(range2),
            random.choice(range3),
            random.choice(range4),
            random.choice(range5)
        ]
        csv_writer.writerow(row_data)

