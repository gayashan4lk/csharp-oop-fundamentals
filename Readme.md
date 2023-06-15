# Stark Customer Management system
## Business Requirements
- Manage business, residential, government and educator types of customers
- Manage our products
- Accept orders from customer online or through our call center

## Implementation details
Stages
- Identifying classes
- Separating responsabilities
- Establishing relationships
- Leveraging reuse

Relationships
Customer Repository uses a Customer (Collaboration)
Order has a Customer/Order Item/Address (Composition)
- Aggregation: Order => Customer
- Composition: Order => Order Item
Customer is a Business/Residential/Educator (Inheritance)

## Object-Oriented Programming Fundamentals in C#
More information in this Pluralsight course
https://app.pluralsight.com/library/courses/object-oriented-programming-fundamentals-csharp/table-of-contents