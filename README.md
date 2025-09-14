# 🧪 GraphQL Demo with WebSockets

This is a simple learning project built with **ASP.NET Core** that demonstrates how to use **GraphQL** together with **WebSockets**. The main focus is on exploring **Queries, Mutations, and Subscriptions**, and understanding the difference between **Polling** and the **Pub/Sub pattern**.

---

## ✨ Features

-   Define and execute **GraphQL Queries** and **Mutations**.
-   Implement **GraphQL Subscriptions** using WebSockets (Pub/Sub).
-   Compare **Polling** vs **Pub/Sub** approaches.

---

## 📂 Project Structure

-   `Query.cs` – Defines available GraphQL queries.
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
---

## 🔍 Example Operations

### Query

```graphql
query {
  books {
    id
    title
    author {
      name
    }
  }
}
```

### mutation

```graphql
mutation {
  addBook(book: { title: "New Book", authorId: 1 }) {
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
  
