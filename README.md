# ScriptableEvents

ItemEvents are created through the 'create asset' menu. Example: OnItemPickedUp.
An ItemEvent contains a collection of ItemEventListeners that will be notified when the event is raised.
The Item script has a reference to the OnItemPickedUp event.
The Inventory has a component ItemEventListener attached to its GameObject.
The ItemEventListener listens to the OnItemPickedUp event (by adding itself to the list of listeners in the event), and stores an ItemUnityEvent as a response.
When ItemEvent is raised on an Item, the ItemUnityEvent on the listener will be invoked as the response to the event.
