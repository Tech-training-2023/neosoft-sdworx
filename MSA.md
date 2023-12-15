# Microservice Application aka MSA
## Why MSA?
- Modern cloud applications need to be fast, agile, massively scalable, and reliable as per current business demands.
- In a microservices architecture, a large application is split up into a set of smaller services.
- Each microservice typically encapsulates simple business logic, which you can scale out or in. 
- You test, deploy, and manage the microservice independently. 
## What is a Microservices Architecture?
- Microservice applications are composed of small, independently versioned, and scalable customer-focused services that communicate with each other by using standard protocols(like HTTP/HTTPS, WebSocket, or Advanced Message Queuing Protocol (AMQP)) and well-defined interfaces.
- Characterstics of MSA

    
    - Each microservice must be developed autonomously and must be independently deployable.
    - Smaller teams develop a microservice based on a customer scenario and choose the technologies that they use.
    - Each microservice should own its related domain data model and domain logic.
    - They persist their data or the external state in their respective databases. Unlike in a monolithic architecture, microservices don't share databases.
    - They support polyglot programming. For example, the microservices that make up a web application don't need to share the same technology stack, libraries, or frameworks.

