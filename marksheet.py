# Input student details
name = input("Enter student name: ")
roll_no = input("Enter roll number: ")

# Input marks for three subjects
j2ee_marks = float(input("Enter marks in J2EE: "))
python_marks = float(input("Enter marks in Python: "))
cs_marks = float(input("Enter marks in CS: "))

# Calculate total and percentage
total_marks = j2ee_marks + python_marks + cs_marks
max_marks = 300  # Assuming each subject is out of 100
percentage = (total_marks / max_marks) * 100

# Print results
print(f"\nStudent Name: {name}")
print(f"Roll Number: {roll_no}")
print(f"Total Marks: {total_marks} / {max_marks}")
print(f"Percentage: {percentage:.2f}%")
