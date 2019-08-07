This is my solution to the coding challenge presented by Oculys Health Informatics.

the following is a summary of the requirments:

-Show the patients sex and age (M, 32): complete
-Sort the list such that the patients waithing the longest appear at the top: complete(implementation inefficient)

-if a bed is occupied by a patient, display their sex and age: complete

-Patients are assigned to a bed by dragging a patient from the incoming patient list to a specific bed: complete
-Once assigned to a bed the patient should be removed from the incoming list: complete
-Bed assignments should be persisted back to the original source file: complete(implementation may have poor scalability)

View summary:

Index: 
This view will show all the current patients tracked by the application, the user may click the View button to see 
additional details through the Details view

Details:
This view will display a patients waittime, ID, Gender, Date of Birth and location(location is empty if the patient
has not been assigned a bed)

Create: 
This view will allow the user to create a new patient that will be added to the list of managed patients.  
The new patient will be able to be used properly with the rest of the application. Data is validated by the client
side

bed Manager:
This view will allow the user to drag and drop incoming patients into an availiable bed, the move must be saved by
pressing the save button, otherwise the data will not persist.  The patients can be dragged into other patients due
to how the html are built.  There is server side validation that prevents this data being saved.  Client side
validation was not working properly and i was not able to figure out the reasoning.

Created by: Ryan French, 
	    rdhfrench@gmail.com


