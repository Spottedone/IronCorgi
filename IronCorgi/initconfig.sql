CREATE TABLE `accounts` (
	`name`	TEXT NOT NULL,
	`incoming_host`	TEXT NOT NULL,
	`incoming_port`	INTEGER NOT NULL,
	`outgoing_host`	TEXT NOT NULL,
	`outgonig_port`	TEXT NOT NULL,
	`is_default`	INTEGER DEFAULT 'True'
)