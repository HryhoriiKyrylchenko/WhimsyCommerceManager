# Whimsy Commerce Manager

Whimsy is an online marketplace platform where customers can browse and purchase products, and sellers can create accounts to list and manage their products. This platform supports features like user authentication, product management, order processing, and payment handling.

## Table of Contents
1. [Overview](#overview)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Getting Started](#getting-started)
5. [Running the Project Locally](#running-the-project-locally)
6. [Project Structure](#project-structure)
7. [Contributing](#contributing)
8. [License](#license)

---

## Overview

Whimsy is designed to be a versatile marketplace that can scale for both individual sellers and larger business needs. It combines the functionality of well-known marketplaces like Etsy and Amazon, allowing both buyers and sellers to interact, complete transactions, and manage their products and orders.

---

## Features

- **User Authentication**: Sellers and buyers can create accounts, log in, and manage profiles.
- **Product Management**: Sellers can list, update, and delete products, including managing product details such as price, stock, and descriptions.
- **Order Processing**: Customers can place orders, track them, and receive notifications. Sellers can manage orders, ship products, and track the status of shipments.
- **Payments**: The platform supports payment integration, allowing customers to securely pay for their orders.
- **Search and Filters**: Customers can search for products by name, category, or price, and filter results accordingly.

---

## Tech Stack

- **Backend**: .NET 8 (C#)
- **Frontend**: React.js (for future implementation, as needed)
- **Database**: SQL Server (or another preferred database solution)
- **Authentication**: JWT (JSON Web Tokens) for secure user authentication
- **Payment Gateway**: Integration with popular payment processors (e.g., Stripe, PayPal)
- **Hosting**: Azure or AWS (depending on your needs)

---

## Getting Started

To get started with the project, follow the instructions below to set up the development environment:

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) (for backend development)
- [Node.js](https://nodejs.org/) (if developing the frontend)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or equivalent database system

---

## Running the Project Locally

Follow these steps to run Whimsy locally on your machine:

### Backend Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/HryhoriiKyrylchenko/WhimsyCommerceManager
   cd whimsy
