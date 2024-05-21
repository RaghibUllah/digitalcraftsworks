<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Student Registration Form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 20px;
        }
        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 600px;
            margin: auto;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
            color: red;
        }
        input, select, textarea {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        input:focus, select:focus, textarea:focus {
            border-color: blue;
        }
        button {
            padding: 10px 15px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        button:hover {
            background-color: #45a049;
        }
        .error {
            color: red;
            margin-top: 5px;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="registrationForm">
        <div class="form-group">
            <label for="studentName">Student Name</label>
            <input type="text" id="studentName" name="studentName">
            <div class="error" id="studentNameError"></div>
        </div>
        <div class="form-group">
            <label for="birthDate">Birth Date</label>
            <input type="date" id="birthDate" name="birthDate">
            <div class="error" id="birthDateError"></div>
        </div>
        <div class="form-group">
            <label for="gender">Gender</label>
            <select id="gender" name="gender">
                <option value="">Select</option>
                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>
            <div class="error" id="genderError"></div>
        </div>
        <div class="form-group">
            <label for="address">Address</label>
            <textarea id="address" name="address"></textarea>
            <div class="error" id="addressError"></div>
        </div>
        <div class="form-group">
            <label for="city">City</label>
            <input type="text" id="city" name="city">
            <div class="error" id="cityError"></div>
        </div>
        <div class="form-group">
            <label for="state">State</label>
            <input type="text" id="state" name="state">
            <div class="error" id="stateError"></div>
        </div>
        <div class="form-group">
            <label for="postalCode">Postal Code</label>
            <input type="text" id="postalCode" name="postalCode">
            <div class="error" id="postalCodeError"></div>
        </div>
        <div class="form-group">
            <label for="email">Email</label>
            <input type="email" id="email" name="email">
            <div class="error" id="emailError"></div>
        </div>
        <div class="form-group">
            <label for="mobileNumber">Mobile Number</label>
            <input type="text" id="mobileNumber" name="mobileNumber">
            <div class="error" id="mobileNumberError"></div>
        </div>
        <div class="form-group">
            <label for="phoneNumber">Phone Number</label>
            <input type="text" id="phoneNumber" name="phoneNumber">
            <div class="error" id="phoneNumberError"></div>
        </div>
        <div class="form-group">
            <label for="workNumber">Work Number</label>
            <input type="text" id="workNumber" name="workNumber">
            <div class="error" id="workNumberError"></div>
        </div>
        <div class="form-group">
            <label for="company">Company</label>
            <input type="text" id="company" name="company">
            <div class="error" id="companyError"></div>
        </div>
        <div class="form-group">
            <label for="courses">Courses</label>
            <select id="courses" name="courses">
                <option value="">Select</option>
                <option value="Course 1">Course 1</option>
                <option value="Course 2">Course 2</option>
                <option value="Course 3">Course 3</option>
                <option value="Course 4">Course 4</option>
                <option value="Course 5">Course 5</option>
                <option value="Course 6">Course 6</option>
                <option value="Course 7">Course 7</option>
                <option value="Course 8">Course 8</option>
                <option value="Course 9">Course 9</option>
                <option value="Course 10">Course 10</option>
            </select>
            <div class="error" id="coursesError"></div>
        </div>
        <div class="form-group">
            <label for="additionalComments">Additional Comments</label>
            <textarea id="additionalComments" name="additionalComments"></textarea>
            <div class="error" id="additionalCommentsError"></div>
        </div>
        <button type="button" onclick="validateForm()">Submit</button>
        <button type="button" onclick="clearFields()">Clear</button>
    </form>

    <script>
        function validateForm() {
            // Clear previous errors
            document.querySelectorAll('.error').forEach(el => el.innerText = '');

            let isValid = true;

            // Validate Student Name
            const studentName = document.getElementById('studentName');
            if (!/^[a-zA-Z ]{1,20}$/.test(studentName.value)) {
                isValid = false;
                document.getElementById('studentNameError').innerText = 'Name must be alphabetic and up to 20 characters.';
            }

            // Validate Birth Date
            const birthDate = document.getElementById('birthDate');
            if (!birthDate.value) {
                isValid = false;
                document.getElementById('birthDateError').innerText = 'Birth Date is required.';
            } else {
                const date = new Date(birthDate.value);
                const today = new Date();
                const age = today.getFullYear() - date.getFullYear();
                if (age > 50 || date.getMonth() > 11 || date.getDate() > 31) {
                    isValid = false;
                    document.getElementById('birthDateError').innerText = 'Please enter a valid birth date.';
                }
            }

            // Validate Gender
            const gender = document.getElementById('gender');
            if (gender.value === '') {
                isValid = false;
                document.getElementById('genderError').innerText = 'Gender is required.';
            }

            // Validate Address
            const address = document.getElementById('address');
            if (address.value.length > 250 || address.value.length === 0) {
                isValid = false;
                document.getElementById('addressError').innerText = 'Address is required and should be up to 250 characters.';
            }

            // Validate City
            const city = document.getElementById('city');
            if (city.value.length > 50 || city.value.length === 0) {
                isValid = false;
                document.getElementById('cityError').innerText = 'City is required and should be up to 50 characters.';
            }

            // Validate State
            const state = document.getElementById('state');
            if (state.value.length > 50 || state.value.length === 0) {
                isValid = false;
                document.getElementById('stateError').innerText = 'State is required and should be up to 50 characters.';
            }

            // Validate Postal Code
            const postalCode = document.getElementById('postalCode');
            if (!/^\d{5}$/.test(postalCode.value)) {
                isValid = false;
                document.getElementById('postalCodeError').innerText = 'Postal Code must be 5 digits.';
            }

            // Validate Email
            const email = document.getElementById('email');
            if (!/^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/.test(email.value) || email.value.length > 250) {
                isValid = false;
                document.getElementById('emailError').innerText = 'Enter a valid email up to 250 characters.';
            }

            // Validate Mobile Number
            const mobileNumber = document.getElementById('mobileNumber');
            if (!/^\d{12}$/.test(mobileNumber.value)) {
                isValid = false;
                document.getElementById('mobileNumberError').innerText = 'Mobile Number must be 12 digits.';
            }

            // Validate Phone Number
            const phoneNumber = document.getElementById('phoneNumber');
            if (phoneNumber.value && !/^\d{12}$/.test(phoneNumber.value)) {
                isValid = false;
                document.getElementById('phoneNumberError').innerText = 'Phone Number must be 12 digits if entered.';
            }

            // Validate Work Number
            const workNumber = document.getElementById('workNumber');
            if (workNumber.value && !/^\d{12}$/.test(workNumber.value)) {
                isValid = false;
                document.getElementById('workNumberError').innerText = 'Work Number must be 12 digits if entered.';
            }

            // Validate Company
            const company = document.getElementById('company');
            if (company.value.length > 150 || company.value.length === 0) {
                isValid = false;
                document.getElementById('companyError').innerText = 'Company is required and should be up to 150 characters.';
            }

            // Validate Courses
            const courses = document.getElementById('courses');
            if (courses.value === '') {
                isValid = false;
                document.getElementById('coursesError').innerText = 'Course selection is required.';
            }

            // Validate Additional Comments
            const additionalComments = document.getElementById('additionalComments');
            if (additionalComments.value.length > 500) {
                isValid = false;
                document.getElementById('additionalCommentsError').innerText = 'Additional Comments should be up to 500 characters.';
            }

            // Final validation check
            if (!isValid) {
                alert('Please correct the errors in the form.');
            } else {
                alert('Form submitted successfully!');
                document.getElementById('registrationForm').reset();
            }
        }

        function clearFields() {
            document.getElementById('registrationForm').reset();
            document.querySelectorAll('.error').forEach(el => el.innerText = '');
        }
    </script>
</body>
</html>
