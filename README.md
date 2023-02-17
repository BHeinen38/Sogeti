# Sogeti
Sogeti Code Challenge


Somethings to know about this project:
- it uses MS SQL Server
- it is a full API (front and back)

![Screenshot 2023-02-16 at 5 08 48 PM](https://user-images.githubusercontent.com/88409601/219514161-ae9f5f5c-88ef-4766-abcb-1a4f35458f79.png)
![Screenshot 2023-02-16 at 5 10 50 PM](https://user-images.githubusercontent.com/88409601/219514199-32cc12d8-0a1e-4879-bc73-2cfde24a66c8.png)

- Price is of type double
- you cannot add an order with the same name as another order
- you are able to view, add, and cancel orders. 
- I was also going to include an edit (update) order option but I ran out of time in the two hour window :( There is edit (update) code in the project but there ended up being a bug and was not able to find it in time. It is so close to being done.
- I could very easily add up the total price in the DbContext but ran out of time. Just create a method GetTotal and search through the whole database and add every price and return the final double in the method.
- Uses .Net 6 since .Net 3.1 is so out of date 


