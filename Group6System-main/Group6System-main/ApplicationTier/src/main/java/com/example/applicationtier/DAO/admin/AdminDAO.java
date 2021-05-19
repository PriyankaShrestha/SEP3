package com.example.applicationtier.DAO.admin;

import com.example.applicationtier.models.Customer;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AdminDAO {
    boolean validateCustomer(Customer customer);
    List<Customer> getAllCustomers();
    String removeCustomer(int cprNumber);
}