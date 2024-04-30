# R5T.T0238
Catch-all for types.

Targets the latest .NET target framework to allow types to depend on *any* type in *any* library. (Since the latest framework can depend on libraries targeting all prior frameworks.)

This means the library dependencies (both project and package) of this library will be a snarled mess... but that's ok! This is the types library where that is allowed.

Types should not move at any point in the future! Movement might entail movement in one or both of:

* Project reference location
* Namespace location

Instead, types should be obsoleted. (Marked with the [Obsolete] attribute and a note pointing to the new location of the type. Additionally, include a note in a \<!--...--> XML documentation comment comment of the new type listing prior locations. And finally, put the [Obsolete] attribute right next to the type name since that is the most important location).

This means there will be lots and lots of types in this library, with many being obsolete... but that's ok! This is the types library where that is allowed.

Additionally, there might be change in the concept of the type (another type of "movement").

* Concept (same name, different concept)

After gaining experience by actually using a type, you might find that that the conceptual boundaries of the type implied by the type name are wrong. In this case, want to keep using the same project reference location and name for the type, but you want the type to be different.
Here still, you should obsolete the type, create a new type in a sub-namespace (generally just using an incremented N### suffix), and then leave a note in the obsolete attribute pointing to the new type.
It's a best practice to also leave a note in the \<!--...--> XML documentation comment comment of the new type to list the priors.
It's a good idea to keep all the namespaced types in the same code file, with most recent namespace increment at the top. However, for side-by-side on-screen comparison purposes, types can be put in their own "N###"-suffixed code file.
If you get fed-up with all the numeric versions, you can always create a new types library for the type! (In fact, if a type is important enough to move or change multiple times, that is a good sign the type is important enough for its own types library.)

Aside: As a question, when is it ok to move-and-delete a type or method? When the type is registered with the R5T.L0101 official selections. This will point to its permanent home. At that point, all priors can be deleted too (although it's good to check in changes before deletion).


That is the tradeoff of putting a type in this library: the future costs of moving the type and searching through lots of irrelevant or obsolete entries is exchanged for the immediate benefit of just being able to slap a type into a commonly accessible location.



## Allowed instance types

All data, utility, and type instance types are allowed.
The functionality instance type is also allowed. (To avoid having to create a -T000 types sub-library to be reference by a -F000 functionality sub-library, which would be referenced by this library.)


## Allowed Dependencies

All dependencies are allowed.


## How this library works

If you have an idea for a type, put it in the specific project you are working on.
If you have an idea for a type, and you want to site it in a library to make it commonly accessible, follow the waterfall in the "How To" file for siting types.
If you have an idea for a type, you want it somewhere commonly accessible, and following the waterfall in the "How To" file for siting types doesn't yield an answer, create a new library for the type, and make a new entry for it in the right place in the types waterfall.
But if you have an idea for a type, you want it somewhere commonly accessible, and you don't want to think through siting the type at *all* (either selecting the right library, creating a new library, or putting it one of the a target framework-specific catch-all type library, and it might be complicated with associated functionality)... THIS is the library for you!

Put differently, this library contains any type, that depends on any type, for any of its functionality, that has not been sited in any other library for any reason.


## Contents




## See Also

In reverse waterfall order:

=> R5T.T0238: This library is the bottom of the waterfall.
* R5T.T0237: The same catch-all for types, but those types limited to targeting netstandard2.1.
* R5T.T0221: Catch-all for types targeting netstandard2.1, but with associated functionality dependent on R5T.L0066.
* R5T.T0232: Catch-all for types targeting netstandard2.1, but with no associated functionality or with independent associated functionality (independent even of of R5T.L0066).
* R5T.T0236: IHasX/IWithX strictly-framework (netstandard2.1) with no associated functionality, catch-all.
