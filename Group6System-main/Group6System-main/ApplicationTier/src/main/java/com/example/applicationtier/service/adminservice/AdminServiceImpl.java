package com.example.applicationtier.service.adminservice;

import com.example.applicationtier.DAO.admin.AdminDAO;
import com.example.applicationtier.models.Account;
import com.example.applicationtier.models.Customer;
import com.example.applicationtier.models.DateTime;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.sql.Date;
import java.util.List;

@Service
public class AdminServiceImpl implements AdminService{
    @Autowired
    private AdminDAO adminDAO;

    @Override
    public boolean validateCustomer(Customer customer) {
        boolean customerToValidate = adminDAO.validateCustomer(customer);
        System.out.println("Service to DAO " + customerToValidate);
        return customerToValidate;
    }

    @Override
    public List<Customer> getAllCustomers() throws Exception {
        List<Customer> getAll = adminDAO.getAllCustomers();
        if(!getAll.isEmpty()){
            return getAll;
        }
        throw new Exception("No customers to show!");
    }

    @Override
    public String removeCustomer(int cprNumber){
        System.out.println(cprNumber);
        String customerToRemove = adminDAO.removeCustomer(cprNumber);
        System.out.println("Inside service --> " + customerToRemove);
        return customerToRemove;
    }

    @Override
    public String CreateAccount(int cprNumber) throws Exception {
        Customer customer = null;

        List<Customer> customers = adminDAO.getAllCustomers();
        for (Customer c: customers) {
            if(c.getCprNumber() == cprNumber)
            {
                customer = c;
                break;
            }
        }

        //System.out.println(customer);

        Date d = new Date(System.currentTimeMillis());
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        String date = d.toString();
        System.out.println(date);
        Account account = new Account();
        account.setAccountNumber(accountNumberGenerator());
        account.setDate(date);
=======
        DateTime date = new DateTime(d);
        System.out.println(date);
=======
        DateTime date = new DateTime(d);
        System.out.println(date);
>>>>>>> Stashed changes
       // Account account = new Account(10000.00, accountNumberGenerator(), date);
        Account account = new Account();
        account.setAccountNumber(accountNumberGenerator());
        account.setDate(date.ToDate());
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        account.setBalance(10000.00);
        account.setCustomer(customer);

        System.out.println(account);
        String message = adminDAO.CreateAccount(account);
        return message;
    }

    private long accountNumberGenerator(){
        try {
            long lastAccountNumber = adminDAO.getLastAccountNumber();
            long available = lastAccountNumber + 1;
            System.out.println(lastAccountNumber + " "  + available + " in account number generator");
            return available;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return 0;
    }
}
