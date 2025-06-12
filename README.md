# DataTransferApp2

A .NET WPF application for secure and simple data transfer between a user interface and the Hercules Terminal.

## Features

- **WPF UI**: Modern Windows desktop application using WPF.
- **Textbox1**: Accepts only numeric input, restricted to 16 digits.
- **Data Transfer**: Automatically sends the 16-digit number to the Hercules Terminal upon completion.
- **Receive Data**: Receives data from Hercules Terminal and displays it in Textbox2.

## Usage

1. **Enter Data**: Input a 16-digit numeric value in Textbox1. Only numbers are allowed.
2. **Send to Hercules**: Once all 16 digits are entered, the data is sent to the Hercules Terminal.
3. **Receive from Hercules**: Data sent from Hercules Terminal will appear in Textbox2.

## Setup

1. Clone the repository:
   ```
   git clone <repo-url>
   ```
2. Open the solution in Visual Studio.
3. Build and run the project.

## Notes
- Ensure Hercules Terminal is set up and connected for data transfer.
- The app is designed for demonstration and educational purposes.

## License

This project is licensed under the MIT License. 