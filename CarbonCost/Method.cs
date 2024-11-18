// Base class for User
public class User {
    private String username;
    private String password;

    // Constructor
    public User(String username, String password) {
        this.username = username;
        this.password = password;
    }

    // Getter for username
    public String getUsername() {
        return username;
    }

    // Setter for username
    public void setUsername(String username) {
        this.username = username;
    }

    // Getter for password
    public String getPassword() {
        return password;
    }

    // Setter for password
    public void setPassword(String password) {
        this.password = password;
    }

    // Method to validate user credentials
    public boolean validateCredentials(String inputUsername, String inputPassword) {
        return this.username.equals(inputUsername) && this.password.equals(inputPassword);
    }
}

// Derived class for AdminUser with additional functionality
public class AdminUser extends User {
    private String adminCode;

    // Constructor
    public AdminUser(String username, String password, String adminCode) {
        super(username, password);
        this.adminCode = adminCode;
    }

    // Getter for adminCode
    public String getAdminCode() {
        return adminCode;
    }

    // Setter for adminCode
    public void setAdminCode(String adminCode) {
        this.adminCode = adminCode;
    }

    // Method to validate admin code
    public boolean validateAdminCode(String inputAdminCode) {
        return this.adminCode.equals(inputAdminCode);
    }
}

// Main class to demonstrate login feature
public class CarbonCostApp {
    public static void main(String[] args) {
        // Create a regular user
        User user = new User("user123", "password123");

        // Create an admin user
        AdminUser admin = new AdminUser("admin123", "adminpass", "admincode123");

        // Validate regular user credentials
        if (user.validateCredentials("user123", "password123")) {
            System.out.println("User login successful!");
        } else {
            System.out.println("Invalid user credentials.");
        }

        // Validate admin user credentials and admin code
        if (admin.validateCredentials("admin123", "adminpass") && admin.validateAdminCode("admincode123")) {
            System.out.println("Admin login successful!");
        } else {
            System.out.println("Invalid admin credentials or admin code.");
        }
    }
}
