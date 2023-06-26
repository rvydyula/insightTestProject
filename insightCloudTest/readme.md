## readme ##
The file contains the details of the sections requested in the code challenge

## item1 - deployment pipeline ##
> The build.yml file in the project is a sample build and release code for dotnetcore 2 project
 and stores secret keys.

## item2 - GetProductsAPI ##
> Created a new project - webAPI using .Net Core
> The models -> interfaces folder contains products related interfaces
> A single Products class file is created to capture all the model objects.
    Ideally this can be broken down similar to interfaces. But for simplicity
    of the request all the necessary data is put into this file.
> A new controller - ProductsController is added to hold two end points - one of which is
    <GetProducts> - returns a list of products and all the error messages
                    as per the documentation are created.
                

## item3 - Message upon adding a new product ##
> Within the ProductsCOntroller - an endpoint to add the products is created
    <AddProduct> - accepts the parameter with Products objecta and the code
                    is open to add the logic to add the product to db or file etc
    A send message (SendMessage) function is added to the send email notification /
        add a message to queue which can subscribed to use as web notification.

## item4 - this file :) ##
