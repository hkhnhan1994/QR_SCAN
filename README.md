# QR_SCAN

## Scenario
A factory needs to pack its products, each with its unique line code. The owner wants to track which box contains a specific product.

## Workflow
As products move along the conveyor belt, a line code reader captures the text transferred over the Serial port. The software reads this information and stores the products in a temporary storage until the box is full. Once the box reaches capacity, the software generates a QR code representing all the products within that box (Box ID). Simultaneously, the software sends a message via the Serial port to a QR code printer, instructing it to print the recently generated QR code onto the box. If a customer scans the QR code on the box, they can view all the product codes contained within.

## Input/Output
- **Input:** Serial Port messages from the line code reader.
- **Output:** Serial Port messages to the QR code printer, QR code image.

## Requirements
- .NET Framework v4.8
- Serial port driver
