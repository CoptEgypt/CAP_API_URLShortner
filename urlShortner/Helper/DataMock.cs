using urlShortner.Models;

namespace UrlShortner.Helper;

public class DataMock
{
    public static readonly List<User> Users =
    [
        new User
        {
            FirstName = "Filobatire",
            LastName = "henein",
            Email = "heneinfilobatire+ksjdksjdkjsdksjdkjs@gmail.com",
            Password = "Whatisup!@#",
            PasswordSalt = "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11",
            HashedPass =
                "ta3HZQJH9azH7IwoztXC8Lj++B0vtEcBZ6iZFjRc1nr0r7yCj0klxcmzpoqpPSh/olPJQ9KW4HXDoWF2cFZsHg==",
            Roles = ["Emperor", "Priest"]
        },
        new User
        {
            FirstName = "Alice",
            LastName = "Anderson",
            Email = "alice.anderson@example.com",
            Password = "S3curePass!23",
            PasswordSalt = "d1e2f3g4-h5i6-j7k8-l9m0-n1o2p3q4r5s6",
            HashedPass =
                "CRxoGi85HjXxFQyEflnN8Ca+cAhXwmit1hYM6G4tR9Cc+Qwb+9RTZsfOGpoOEZ5vggML9foUcaZ8BoNa0TiR1Q==",
            Roles = ["Administrator", "User"]
        },
        new User
        {
            FirstName = "Brian",
            LastName = "Baker",
            Email = "brian.baker@example.com",
            Password = "Passw0rd!",
            PasswordSalt = "e2f3g4h5-i6j7-k8l9-m0n1-o2p3q4r5s6t7",
            HashedPass =
                "WmexgeRtHDnqHi+dZKXcrnfs8CMhF8tt7rwRoKF0Jimhskpzw6IbnMO9RB8KDAMntVVpZdGyxW84AxTNym5DBQ==",
            Roles = ["Moderator"]
        },
        new User
        {
            FirstName = "Catherine",
            LastName = "Clark",
            Email = "catherine.clark@example.com",
            Password = "MyPass@123",
            PasswordSalt = "f3g4h5i6-j7k8-l9m0-n1o2-p3q4r5s6t7u8",
            HashedPass =
                "xIeTUhhSNlTltvuahE/zzr5milYRE/w3+QTWoCuWGuc1N0W7E7h9gBkS4j5q+zLm+dMt2M/Qs7Y/dtAsDYP5Ng==",
            Roles = ["Editor"]
        },
        new User
        {
            FirstName = "David",
            LastName = "Davis",
            Email = "david.davis@example.com",
            Password = "Secure1234",
            PasswordSalt = "g4h5i6j7-k8l9-m0n1-o2p3-q4r5s6t7u8v9",
            HashedPass =
                "axb6N4gGkIyt239u5RDbJbBHND0S58q9qRRt/Rq+ZYA57y6R2TV19lanrGdK7nSbYvlAs4hzvXEE8OVFkvu/bg==",
            Roles = ["Viewer"]
        },
        new User
        {
            FirstName = "Emily",
            LastName = "Evans",
            Email = "emily.evans@example.com",
            Password = "Password567!",
            PasswordSalt = "h5i6j7k8-l9m0-n1o2-p3q4-r5s6t7u8v9w0",
            HashedPass =
                "fzs0iBQmajAwpqhWAiuMtARXoXRxXKlyB/yKeCBoEyGARQu4y1WUzvKwVFMAB4U52ao7J0JR+MM2TQqpDVItBw==",
            Roles = ["Administrator"]
        },
        new User
        {
            FirstName = "Frank",
            LastName = "Franklin",
            Email = "frank.franklin@example.com",
            Password = "P@ssword123",
            PasswordSalt = "i6j7k8l9-m0n1-o2p3-q4r5-s6t7u8v9w0x1",
            HashedPass =
                "ZNY3U7kLk8xILCuLnCkhsgSPEj6POzErNk+uAEdzLXPKXB64O+nnJfIWRdoK85QoY9Ti4ATs2r7LAxWExTkMCg==",
            Roles = ["User"]
        },
        new User
        {
            FirstName = "Grace",
            LastName = "Gonzalez",
            Email = "grace.gonzalez@example.com",
            Password = "Secure!Pass",
            PasswordSalt = "j7k8l9m0-n1o2-p3q4-r5s6-t7u8v9w0x1y2",
            HashedPass =
                "Mqa9ovXqeUE/7Gt4yRtGvvPhfXUIp0EkwVF6QN/qJuvDkMOd3tTn/wGZBYCeJwjRwi/MoQztnEPiYdSemvpgRA==",
            Roles = ["Moderator"]
        },
        new User
        {
            FirstName = "Henry",
            LastName = "Harris",
            Email = "henry.harris@example.com",
            Password = "Mypass789",
            PasswordSalt = "k8l9m0n1-o2p3-q4r5-s6t7-u8v9w0x1y2z3",
            HashedPass =
                "J5Cvi8FYXrAtW3Vtg+lYB+OofEhtUVNDEZ/V8ECRGsvyQMQscJ1gW/6Ulc1MrPvdVIGSIpMfOu9iynRxOm4+lw==",
            Roles = ["Editor"]
        },
        new User
        {
            FirstName = "Isabella",
            LastName = "Ivy",
            Email = "isabella.ivy@example.com",
            Password = "Password!789",
            PasswordSalt = "l9m0n1o2-p3q4-r5s6-t7u8-v9w0x1y2z3a4",
            HashedPass =
                "laW1Td2+WDzWhcXAJnSgipf5WxXnxm2qiuM7hKASlmqarv2zDpd4ap3rIyenPcMbnFYgtqGTcN2VkG1hsxQSkg==",
            Roles = ["Viewer"]
        },
        new User
        {
            FirstName = "Jack",
            LastName = "Johnson",
            Email = "jack.johnson@example.com",
            Password = "S3cureP@ss",
            PasswordSalt = "m0n1o2p3-q4r5-s6t7-u8v9-w0x1y2z3a4b5",
            HashedPass =
                "LmjKuZsLBbyUkriXMsT/M10+bBsXIFX3tSOiPZYn8ZEAgBgT9Y+0c/+Aegpu9giUKu1OWBV+aTmx2J54CbP4lg==",
            Roles = ["Administrator"]
        },
        new User
        {
            FirstName = "Katherine",
            LastName = "King",
            Email = "katherine.king@example.com",
            Password = "Pass!word456",
            PasswordSalt = "n1o2p3q4-r5s6-t7u8-v9w0-x1y2z3a4b5c6",
            HashedPass =
                "HCm9At3IPz97H6rdPyRELPt0UsISJSKYWb5d8xnFcx+MGWSERbai9Gsk1cmn1rCrpJKd+lrcFoms74pjHbYxqw==",
            Roles = ["User"]
        },
        new User
        {
            FirstName = "Liam",
            LastName = "Lewis",
            Email = "liam.lewis@example.com",
            Password = "P@ssword567",
            PasswordSalt = "o2p3q4r5-s6t7-u8v9-w0x1-y2z3a4b5c6d7",
            HashedPass =
                "ksg0kHRoFPKcjQyjJohpTPSZmk1XhmRhMWqCy04TFZdce/+PT3DfxXCEQB8h8cn5rReYjn7cHvSL3yPlgnOKvA==",
            Roles = ["Moderator"]
        },
        new User
        {
            FirstName = "Mia",
            LastName = "Martin",
            Email = "mia.martin@example.com",
            Password = "SecurePass890!",
            PasswordSalt = "p3q4r5s6-t7u8-v9w0-x1y2-z3a4b5c6d7e8",
            HashedPass =
                "oEIziplgEWx3JOtjYqU13yt2v4BszWBQkLapv+81EJDbuielf1EVURT6ebs/XPd14L9vBqg9UJRR4yT/3jjj4g==",
            Roles = ["Editor"]
        },
        new User
        {
            FirstName = "Salam",
            LastName = "Morcos",
            Email = "salam.morcos+testspsd@gmail.com",
            Password = "OAuth2.0Pass",
            PasswordSalt = "n/a",
            HashedPass =
                "mhJOSZzYuAS/xuEY2eSaVYJEig3xu/KCs2Q2Sj1h+iBvghxgjxzs87ShbXxmdZTOaZIPRbKmCMeKpwn3LzrfMw==",
            Roles = ["Deacon"]
        },
    ];

    public static readonly List<string> Roles =
    [
        "Emperor",
        "Priest",
        "Deacon",
        "Grand Wizard",
        "Space Cowboy",
        "Supreme Overlord",
        "Chief Happiness Officer"
    ];

    public static readonly List<string> Permissions =
    [
        "AddCustomer",
        "EditCustomer",
        "DeleteCustomer",
        "ViewCustomerDetails",
        "ManageInventory",
        "PlaceOrders",
        "ManagePayments",
        "ViewReports",
        "AssignTasks",
        "ApproveExpenses",
        "ScheduleMeetings",
        "ManageProjects",
        "AccessSensitiveData",
        "GenerateReports",
        "ModerateDiscussions"
    ];

    public static readonly List<(string Role, string Permission)> RolesPermissionsMatrix =
    [
        ("Priest", "AddCustomer"),
        ("Priest", "EditCustomer"),
        ("Priest", "DeleteCustomer"),
        ("Priest", "ViewCustomerDetails"),
        ("Priest", "ManageInventory"),
        ("Priest", "PlaceOrders"),
        ("Priest", "ManagePayments"),
        ("Priest", "ViewReports"),
        ("Priest", "AssignTasks"),
        ("Emperor", "ApproveExpenses"),
        ("Emperor", "ScheduleMeetings"),
        ("Emperor", "ManageProjects"),
        ("Emperor", "AccessSensitiveData"),
        ("Deacon", "ScheduleMeetings"),
        ("Deacon", "AccessSensitiveData"),
        ("Grand Wizard", "GenerateReports"),
        ("Grand Wizard", "ModerateDiscussions"),
        ("Grand Wizard", "ViewReports"),
        ("Space Cowboy", "ViewCustomerDetails"),
        ("Space Cowboy", "ManageInventory"),
        ("Space Cowboy", "PlaceOrders"),
        ("Supreme Overlord", "ApproveExpenses"),
        ("Supreme Overlord", "ManageProjects"),
        ("Chief Happiness Officer", "ViewReports"),
        ("Chief Happiness Officer", "AssignTasks"),
        ("Chief Happiness Officer", "GenerateReports")
    ];

    public static User? GetUserByEmail(string email)
    {
        return Users.FirstOrDefault(user =>
            user.Email!.Equals(email, StringComparison.OrdinalIgnoreCase)
        );
    }
}
