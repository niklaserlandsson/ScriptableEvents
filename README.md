# ScriptableEvents

ItemEvents are created through the 'create asset' menu. Example: OnItemPickedUp.

An ItemEvent contains a collection of ItemEventListeners that will be notified when the event is raised.

The Item script has a reference to the OnItemPickedUp event.

The Inventory has a component ItemEventListener attached to its GameObject.

The ItemEventListener listens to the OnItemPickedUp event (by adding itself to the list of listeners in the event), and stores an ItemUnityEvent as a response.

When clicking an Item in the game view the ItemEvent on the Item is raised.

The ItemUnityEvent on the listener will be invoked as the response to the event and the Item will be added to the Inventory.

Right clicking the Item in the game view will raise the event OnItemDropped, which removes the Item from the Inventory.
