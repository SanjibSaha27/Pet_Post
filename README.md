# Pet_Post
**Mini Business Requirements Document (BRD) – PetPost**

**1. Business Objective**
The objective of the PetPost project is to assist a small animal rescue organization in sharing information about adoptable pets online. By creating a simple, accessible website hosted on AWS, volunteers can upload details and images of animals available for adoption. This system aims to streamline the pet listing process, increase visibility of rescue animals, and improve adoption rates, all while maintaining affordability and ease of use.

**3. Stakeholders**
Shelter Staff – Manage pet information, verify uploads, and ensure listings are accurate.
Volunteers – Upload pet details and photos to the website.
Potential Adopters – Browse the website to find and adopt available pets.

**5. Functional Requirements**
**Upload Pet Information:**
Volunteers must be able to enter a pet’s name, breed, age, and photo using a simple web form.
The uploaded image should be stored in Amazon S3.
The pet’s metadata (name, age, breed, image URL) should be saved in a flat JSON file.

**Display Pet Listings:**
The website should display a list of all pets currently available for adoption.
Each listing must include the pet’s image, name, breed, and age.

**4. Non-Functional Requirements**
**Simplicity & Cost-Efficiency:**
The solution must remain simple and low-cost, avoiding unnecessary infrastructure.


**Public Accessibility:**
The site must be publicly accessible via a web browser using the EC2 public IP.

**Maintainability:**
Volunteers should be able to update or add pet information without technical training.

**5. Constraints**
The solution must:
Use only Amazon EC2 (to host the website) and Amazon S3 (to store pet images).
Avoid using any databases or authentication mechanisms.
Store all data in JSON or flat text files on EC2 or S3.

**6. Assumptions**
All uploads are performed by trusted volunteers, removing the need for user authentication.
There is no expectation of high traffic, making the use of flat files and lightweight architecture sufficient.
No real-time data updates are required—JSON-based listings are acceptable for this use case.

**7. Technology Stack Overview**
**Frontend:** HTML/CSS served by ASP.NET Core Razor views.
**Backend:** ASP.NET Core application hosted on an EC2 Windows instance.
**Storage:**
Pet images are uploaded to Amazon S3.
Pet details are stored in a local JSON file on the EC2 server (e.g., pets.json).
**Hosting:** IIS configured on an EC2 Windows Server instance.
**Deployment:** Via manual RDP file transfer and IIS configuration.

**8. Success Criteria**
Website is accessible using EC2's public IP.
At least one pet listing is visible with full details and image.
Image uploads are working and confirmed to be stored in S3.
GitHub repository includes source code, views, controllers, and setup files.
A screenshot or video demonstrates the upload and listing workflow.
