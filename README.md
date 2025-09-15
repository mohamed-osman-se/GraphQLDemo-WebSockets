
# 🧪 GraphQL Demo with WebSockets

This is a learning project built with **ASP.NET Core 9** that demonstrates how to use **GraphQL** together with **WebSockets**.  
The main focus is on exploring **Queries, Mutations, and Subscriptions**, understanding the difference between **Polling** and the **Pub/Sub pattern**, and applying **query optimization practices**.

---

## ✨ Features

-   Define and execute **GraphQL Queries** and **Mutations**.
-   Implement **GraphQL Subscriptions** using WebSockets (**Pub/Sub pattern**).
-   Compare **Polling** vs **Pub/Sub** real-time data delivery.
-   Use **Projection** to fetch only the required fields.
-   Optimize queries to avoid **over-fetching** and unnecessary payloads.
-   Handle the **N+1 problem** by structuring queries efficiently.

---

## 📂 Project Structure

-   `Query.cs` – Defines available GraphQL queries with projection applied.
-   `Mutation.cs` – Defines mutations (e.g., add new records).
-   `Subscription.cs` – Defines GraphQL subscriptions using WebSockets.
-   `SeedData.cs` – Seeds initial data for testing.
-   `Program.cs` – Application entry point and GraphQL configuration.

---

## 🚀 Getting Started

### Prerequisites

-   [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)

### Run the Project

 ```bash

   git clone https://github.com/mohamed-osman-se/GraphQLDemo-WebSockets.git
  cd GraphQLDemo-WebSockets
  dotnet run

```
#### Move to http://localhost:5198/graphql/
---

## 🔍 Example Operations

### Query

```graphql
query {
  authors {
    id
    name
    books {
      id
      title
    }
  }
}
```

### mutation

```graphql
mutation {
  addBook(input:{ title: "New Book", authorId: 1 }) {
    id
    title
  }
}


```

### subscription

```graphql
subscription {
  bookAdded {
    id
    title
  }
}
```

---

## 📌 Notes
-   This project is for educational purposes only and is not intended for production use.
  
