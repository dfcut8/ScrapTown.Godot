# Just Random thoughts

## Focus on main loop

We start only with one building in the middle.

Visually, we will have road and river. I'm not sure if we have anything to do with the road, but probably we will be setting something their later. Same for the river. We will define and detail this part later.

For our main loop, we just focus on two things:

1. Update main building
2. Add new building

## What we need to work with main building

### Scenes

Each scene is an basic Sprite2D. Should be clickable, so we need to add Area2D.

We need at least three scenes for our first stage.

Suggested visual style is just a tent with flag. We need flag because our regular housing will be tents also. With each upgrade we will just add more tents.

### Cursor

Just a cursor, so we can mouse over the building.

### UI to upgrade main building

Player mouse over the building. Building highlights. Hint shown "click to upgrade". Player must click a building to upgrade it . On clicking will open a separate ui area with confirmation to upgrade.
When upgrade is confirmed, we need to replace current sprite with upgraded one.

How to implement highlighting. Two ideas, either it should be outline, or should be just something base style.

### Tile map

Technically we do not need it yet...

### Other buildings

We need at least the following:

1. Housing (to increase our available housing)
2. Green house (to increase food production)
3. Exchange center (to increase scrap production) TODO: need to think about better naming

TODO: Not clear what upgrade will do. Need to brainstorm.

## Ideas

Do we even need a graphics in normal way of thinking about it? What if we just use a ASCII pseudo-graphics to represent everything.

I also think about using more older style ui as it was in KOEI games or in old DOS games. See "Reunion" for reference. Idea is that everything will be done in dedicated ui panel instead of popups, etc... However this will mean, we are not using modern ux patterns.

Agents to try:
letsagents/godot-mcp
hybridindie/godot-mcp

I'm still thinking if I should switch to using agents for this project...
