# License-Generator

This is a project meant as an example on how you can generate license keys for your product, and how to implement the check in your MSI package.
Of course, in your MSI you would need a .DLL custom action that checks if the inputed license key is correct. The decryptor is in my other repository [here](https://github.com/marinalexandruradu/License-Decryptor).

The license generator composes a license out of two parts:
Part 1: We generate a random 9 digit number and we use the [ISBN-10 check digit algoritm](https://planetcalc.com/7744/) to add a check digit control. This will result in the first 10 digits of the license key.
Part 2: We generate a random date in 2021 and convert it to UNIX timestamp

![image](https://user-images.githubusercontent.com/13455334/112224499-05e4c980-8c34-11eb-8729-95396e4bca80.png)

The application also allows you to generate multiple keys. Just input the number and these will be written in a text file near the executable

![image](https://user-images.githubusercontent.com/13455334/112224557-1a28c680-8c34-11eb-8ec2-cdc2d2abe870.png)
