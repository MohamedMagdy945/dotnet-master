# Event in C#

## Definition
An Event in C# is a mechanism that allows a class to notify other classes or objects when something happens.  
It is based on delegates and provides a way to implement the publisher-subscriber pattern.

---

## Purpose
Events are used to:

- Enable communication between objects without tight coupling
- Implement the observer pattern
- Notify multiple subscribers when a specific action occurs
- Support event-driven programming models

---

## How It Works
1. A class declares an event using a delegate type.
2. Other classes subscribe to the event by attaching methods (event handlers).
3. When the event is triggered (raised), all subscribed methods are invoked automatically.

---

## Key Characteristics

- Built on top of delegates
- Supports multiple subscribers (multicast)
- Provides encapsulation to restrict direct invocation
- Typically follows the naming convention: `[Action]` + `Event` (e.g., `DataReceivedEvent`)
- Cannot be invoked directly outside the defining class

---

## Event vs Delegate

- Delegate defines a method signature and holds references to methods.
- Event uses a delegate to notify subscribers.
- Delegate allows direct invocation.
- Event restricts direct invocation to the publisher class only.

---

## Benefits

- Loose coupling between publisher and subscriber
- Flexible notification mechanism
- Supports multiple listeners
- Central to GUI, asynchronous programming, and real-time updates

---

## When to Use Events

Use events when:

- One class needs to notify other classes about changes or actions
- You are implementing callback mechanisms
- You are designing GUI applications or event-driven systems
- You want multiple objects to respond to the same action independently

---

## Summary
An Event in C# is a powerful feature that enables classes to communicate in a loosely coupled manner.  
It relies on delegates, supports multiple subscribers, and is central to event-driven and asynchronous programming.