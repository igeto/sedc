class Monkey extends Animal {
	constructor(name, kind, isCarnivore, monkeyKind, canClimb) {
		super(name, "monkey", false);
		this.monkeyKind = monkeyKind;
		this.canClimb = canClimb;
	}
	climb(tree) {
		if (!canClimb) {
		throw Error(`${this.name} can't climb ${tree}`);
		}
		return `${this.name} climbed ${tree}`;
	}
}